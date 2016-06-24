/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 02/10/2015
 * Time: 15:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;
using System.Threading;
using System.Reflection;
using System.Collections.Generic;

namespace LotoFacil.Classes
{
	/// <summary>
	/// Description of Jogo.
	/// </summary>
	public class Jogo
	{
		public static int contador = 0;
		
		// Campos
		private readonly List <int> bolas = new List<int>();
		
		// Propriedades
		public int Numero { get; set; }
		public Guid Uuid { get; set; }
		public DateTime Data { get; set; }
		public int Bola01 { get; set; }
		public int Bola02 { get; set; }
		public int Bola03 { get; set; }
		public int Bola04 { get; set; }
		public int Bola05 { get; set; }
		public int Bola06 { get; set; }
		public int Bola07 { get; set; }
		public int Bola08 { get; set; }
		public int Bola09 { get; set; }
		public int Bola10 { get; set; }
		public int Bola11 { get; set; }
		public int Bola12 { get; set; }
		public int Bola13 { get; set; }
		public int Bola14 { get; set; }
		public int Bola15 { get; set; }
		public int Bola16 { get; set; }
		public int Bola17 { get; set; }
		public int Bola18 { get; set; }
		public int MaiorSequencia { get; set; }
		public string EstiloSequencias { get; set; }
		public int MaiorIntervalo { get; set;}
		public string EstiloSequenciasCompleto { get; set; }
		public string ImparPar { get; set; }
		public int Impares { get; set;}
		public int Pares{ get; set;}
		public string EstiloImparPar { get; set; }
		public List<int> Bolas { get{return bolas;} }
		
		public Jogo()
		{
		}
		
		/// <summary>
		/// Verifica quantos números da sequência informada são coincidentes com o jogo atual
		/// </summary>
		/// <param name="sequencia"></param>
		/// <returns></returns>
		public int SequenciaCoincidente(string sequencia) {
			sequencia = sequencia.Trim();
			String[] separados = sequencia.Split(' ');
			List<int> numeros = new List<int>();
			
			foreach (string item in separados) {
				numeros.Add(int.Parse(item));
			}
			numeros.Sort();
			
			List<int> intersecao = numeros.FindAll(x => bolas.Contains(x));
			
			return intersecao.Count;
		}
		
		public Jogo(String linha)
		{
			CarregarLinha(linha);
		}
		
		public void AnalisarJogo() {
			bolas.Sort();
			
			AnalisadorJogo anlMaiorSequencia = new AnalisadorJogo();
				
			Thread thrMaiorSequencia = new Thread (new ParameterizedThreadStart(anlMaiorSequencia.Analisar));
			thrMaiorSequencia.Start (this);
			
			thrMaiorSequencia.Join();
			
			this.MaiorSequencia = anlMaiorSequencia.MaiorSequencia;
			this.EstiloSequencias = anlMaiorSequencia.EstiloSequencias;
			this.MaiorIntervalo = anlMaiorSequencia.MaiorIntervalo;
			this.EstiloSequenciasCompleto = anlMaiorSequencia.EstiloSequenciasCompleto;
			this.Impares = anlMaiorSequencia.Impares;
			this.Pares = anlMaiorSequencia.Pares;
			this.ImparPar = anlMaiorSequencia.ImparPar;
			this.EstiloImparPar = anlMaiorSequencia.EstiloImparPar;
		}
		
		private void CarregarLinha(String linha) {
			linha = linha.Trim();
			String[] separados = linha.Split('\t');
			Numero = int.Parse(separados[0]);
			Data = DateTime.Parse(separados[1]);
			bolas.Add(Int32.Parse(separados[2]));
			bolas.Add(Int32.Parse(separados[3]));
			bolas.Add(Int32.Parse(separados[4]));
			bolas.Add(Int32.Parse(separados[5]));
			bolas.Add(Int32.Parse(separados[6]));
			bolas.Add(Int32.Parse(separados[7]));
			bolas.Add(Int32.Parse(separados[8]));
			bolas.Add(Int32.Parse(separados[9]));
			bolas.Add(Int32.Parse(separados[10]));
			bolas.Add(Int32.Parse(separados[11]));
			bolas.Add(Int32.Parse(separados[12]));
			bolas.Add(Int32.Parse(separados[13]));
			bolas.Add(Int32.Parse(separados[14]));
			bolas.Add(Int32.Parse(separados[15]));
			bolas.Add(Int32.Parse(separados[16]));
			bolas.Sort();
			
			for(int i = 1; i <= bolas.Count; i++){
				PropertyInfo propertyInfo = this.GetType().GetProperty("Bola" + i.ToString("00"));
				propertyInfo.SetValue(this, bolas[i - 1], null);
			}
			
			AnalisarJogo();
		}
		
		public override string ToString() {
			StringBuilder sb = new StringBuilder(200);
			foreach (int bola in bolas) {
				if (sb.Length != 0) {
					sb.Append(" ");
				}
				sb.Append(bola.ToString("00"));
			}
			
			return sb.ToString();
		}
	}
}
