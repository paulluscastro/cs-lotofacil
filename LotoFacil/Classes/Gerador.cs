/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 30/11/2015
 * Time: 20:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Reflection;
using System.Collections.Generic;

using LotoFacil.Enums;
using LotoFacil.Validadores;

namespace LotoFacil.Classes
{
	/// <summary>
	/// Description of Gerador.
	/// </summary>
	public class Gerador
	{
		// Campos
		private List<Jogo> jogosPassados = null;
		public int jogosReprovados = 0;
		public int repCoincidencias = 0;
		public int repSequencia = 0;
		public int repIntervalo = 0;
		public int repParesImpares = 0;
		public int repEstilo = 0;
		public int repEstiloImparPar = 0;
		public int repExistente = 0;
		
		// Eventos
		public event EventHandler OnGerarJogo;
		public event EventHandler OnBolaSorteada;
		public event JogoAprovadoHandler OnJogoAprovado;
		public event JogoReprovadoHandler OnJogoReprovado;

		// Propriedades
		public int JogosReprovados
		{ 
			get{
				return this.jogosReprovados;
			}
		}
		public int RepCoincidencias
		{ 
			get{
				return this.repCoincidencias;
			}
		}

		public int RepSequencia
		{
			get{
				return this.repSequencia;
			}
		}

		public int RepIntervalo{
			get{
				return this.repIntervalo;
			}
		}
		public int RepParesImpares{
			get{
				return this.repParesImpares;
			}
		}
		public int RepEstilo{
			get{
				return this.repEstilo;
			}
		}
		public int RepEstiloImparPar{
			get{
				return this.repEstiloImparPar;
			}
		}
		public int RepExistente{
			get{
				return this.repExistente;
			}
		}
		
		// propriedades
		public List<ValidadorGenerico> Validadores { get; set; }
		public BancoDados.BancoDados Banco { get; set; }

		public Gerador()
		{
			ZerarContadores();
		}
		
		
		private void ReprovarJogo(MotivoReprovacao motivo) {
			jogosReprovados++;
			
			switch (motivo) {
				case MotivoReprovacao.COINCIDENCIA:
					repCoincidencias++;
					break;
				case MotivoReprovacao.ESTILO:
					repEstilo++;
					break;
				case MotivoReprovacao.ESTILO_IMPAR_PAR:
					repEstiloImparPar++;
					break;
				case MotivoReprovacao.EXISTENTE:
					repExistente++;
					break;
				case MotivoReprovacao.INTERVALO:
					repIntervalo++;
					break;
				case MotivoReprovacao.PARES_IMPARES:
					repParesImpares++;
					break;
				case MotivoReprovacao.SEQUENCIA:
					repSequencia++;
					break;
			}
		}
		
		public void ZerarContadores() {
			jogosReprovados = 0;
			repCoincidencias = 0;
			repSequencia = 0;
			repIntervalo = 0;
			repParesImpares = 0;
			repEstilo = 0;
			repEstiloImparPar = 0;
			repExistente = 0;
		}
		
		private int Seeder()
		{
			String temp = Guid.NewGuid().ToString();
			String numero = "";
			foreach (char c in temp) {
				if (char.IsDigit(c)) {
					numero += c.ToString();
				}
				if (numero.Length == 9) break;
			}
			
			return Convert.ToInt32(DateTime.Now.Ticks % Int64.Parse(numero));
		}
		
		public void GerarJogos(int quantidadeJogos) {
			GerarJogos(quantidadeJogos, 15);
		}
		
		public void GerarJogos(int quantidadeJogos, int quantidadeNumeros) {
			DateTime inicio = DateTime.Now;
			System.Diagnostics.Debug.WriteLine("Início: " + inicio.ToString("HH:m:s tt zz"));
			
			List<Jogo> jogosValidos = new List<Jogo>();

			ValidadorGeral validadorGeral = new ValidadorGeral();
			
			ZerarContadores();			
			try {
				if (jogosPassados == null) {
					jogosPassados = Banco.ObterJogosPassados();
				}
				
				validadorGeral.JogosPassados = jogosPassados;
				validadorGeral.BancoAnalise.AddRange(jogosPassados);
				
				while (jogosValidos.Count < quantidadeJogos) {
					RaiseOnGerarJogo(this, new EventArgs());
					// Gerando as bolas
					Jogo jogo = new Jogo();
					while (jogo.Bolas.Count < quantidadeNumeros) {
						RaiseOnBolaSorteada(this, new EventArgs());
						Random random = new Random(Seeder());
						int bola = random.Next(1, 26);
						if (!jogo.Bolas.Contains(bola)) {
							jogo.Bolas.Add(bola);
						}
					}
					
					jogo.Bolas.Sort();
					for(int i = 1; i <= jogo.Bolas.Count; i++){
						PropertyInfo propertyInfo = jogo.GetType().GetProperty("Bola" + i.ToString("00"));
						propertyInfo.SetValue(jogo, jogo.Bolas[i - 1], null);
					}
					
					jogo.AnalisarJogo();
					
					// Verificações para validação do jogo
					MotivoReprovacao motivo = validadorGeral.Validar(jogo);
					ValidadorGenerico validador = null;
					if (motivo == MotivoReprovacao.NENHUM) {
						foreach (ValidadorGenerico validator in Validadores) {
							motivo = validator.Validar(jogo);
							if (motivo == MotivoReprovacao.NENHUM) {
								validador = validator;
								Banco.AdicionarJogoGerado(jogo, validador);
								Banco.Salvar();
								break;
							}
						}
					}
					
					if (motivo != MotivoReprovacao.NENHUM){
						Banco.AdicionarJogoReprovado(jogo, motivo, Validadores);
						Banco.Salvar();
						RaiseOnJogoReprovado(this, new JogoReprovadoArgs(motivo));
					} else {
						RaiseOnJogoAprovado(this, new JogoAprovadoArgs(jogo, validador));
					}
				}
				
				
				DateTime fim = DateTime.Now;
				System.Diagnostics.Debug.WriteLine("Fim: " + fim.ToString("HH:m:s tt zz"));
				TimeSpan diferenca = fim - inicio;
				System.Diagnostics.Debug.WriteLine("Tempo: " + diferenca.ToString("g"));
			} catch (Exception ex) {
				System.Diagnostics.Debug.WriteLine(ex.StackTrace);
				
				DateTime fim = DateTime.Now;
				System.Diagnostics.Debug.WriteLine("Fim: " + fim.ToString("HH:m:s tt zz"));
				TimeSpan diferenca = fim - inicio;
				System.Diagnostics.Debug.WriteLine("Tempo: " + diferenca.ToString("g"));
			}
		}
		
		protected void RaiseOnGerarJogo(object sender, EventArgs args) {
			if (OnGerarJogo != null) {
				OnGerarJogo(sender, args);
			}
		}
		
		protected void RaiseOnJogoAprovado(object sender, JogoAprovadoArgs args) {
			if (OnJogoAprovado != null) {
				OnJogoAprovado(sender, args);
			}
		}
		
		protected void RaiseOnJogoReprovado(object sender, JogoReprovadoArgs args) {
			ReprovarJogo(args.MotivoReprovacao);
			if (OnJogoReprovado != null) {
				OnJogoReprovado(sender, args);
			}
		}
		
		protected void RaiseOnBolaSorteada(object sender, EventArgs args) {
			if (OnBolaSorteada != null) {
				OnBolaSorteada(sender, args);
			}
		}
	}
}
