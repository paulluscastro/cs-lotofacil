/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 02/10/2015
 * Time: 13:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Xml;
using System.Text;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Collections.Generic;

using LotoFacil.Enums;
using LotoFacil.Classes;
using LotoFacil.Validadores;

namespace LotoFacil
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		// List<Jogo> jogosPassados = null;
		Gerador gerador;

		List<ValidadorGenerico> validadores = new List<ValidadorGenerico>();
		BancoDados.BancoDados banco = new BancoDados.BancoDados();
		
		private void CarregarValidadores(){
			if (!File.Exists(BancoDados.BancoDados.CAMINHO + "\\regras.xml"))
				return;
			
			XmlTextReader reader = new XmlTextReader(BancoDados.BancoDados.CAMINHO + "\\regras.xml");
			XmlSerializer serializer = new XmlSerializer(typeof(List<ValidadorGenerico>));
			validadores = (List<ValidadorGenerico>) serializer.Deserialize(reader);
			
			reader.Close();
		
			foreach (ValidadorGenerico validador in validadores) {
				// Adiciona na lista visual
				ListViewItem item = new ListViewItem(validador.MaiorSequencia.ToString());
				item.SubItems.Add(validador.MaiorIntervalo.ToString());
				item.SubItems.Add(validador.NumerosPares.ToString());
				item.SubItems.Add((15 - validador.NumerosPares).ToString());
				item.Tag = validador;
				
				lvRegras.Items.Add(item);
			}
		}
		
		private void SalvarValidadores(){
			XmlTextWriter writer = new XmlTextWriter(BancoDados.BancoDados.CAMINHO + "\\regras.xml", Encoding.UTF8);
			
			XmlSerializer serializer = new XmlSerializer(typeof(List<ValidadorGenerico>));
			serializer.Serialize(writer, validadores);
			writer.Close();
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			gerador = new Gerador();
			gerador.OnGerarJogo += OnGerarJogo;
			gerador.OnBolaSorteada += OnBolaSorteada;
			gerador.OnJogoAprovado += OnJogoAprovado;
			gerador.OnJogoReprovado += OnJogoReprovado;
			
			chkLimparArquivo.Enabled = !File.Exists(BancoDados.BancoDados.CAMINHO_COMPLETO);
			
			if (!File.Exists(BancoDados.BancoDados.CAMINHO_COMPLETO)) {
				Faxineiro faxineiro = new Faxineiro();
				faxineiro.OnArquivoLido += OnArquivoLidoFaxineiro;
				faxineiro.OnLinhaLida += OnLinhaLida;

				Carregador carregador = new Carregador();
				carregador.OnArquivoLido += OnArquivoLidoCarregador;
				carregador.OnLinhaLida += OnLinhaLida;
				
				banco.Faxineiro = faxineiro;
				banco.Carregador = carregador;
			}
			lbCoincidencias.Text = ValidadorGeral.FATOR_COINCIDENCIA + "+ bolas coincidentes em outro jogo: 0";
			CarregarValidadores();
		}
		
		/* *************** MÉTODOS QUE SERÃO INVOCADOS POR DELEGATES *************** */
		private void JogoAnalisadoMaiorSequencia(){
			this.pbMaiorSequencia.Value += 1;
			Application.DoEvents();
		}
		
		private void JogoAnalisadoMaiorIntervalo(){
			this.pbMaiorIntervalo.Value += 1;
			Application.DoEvents();
		}
		
		/* *************** MÉTODOS QUE SERÃO INVOCADOS PELOS EVENTOS *************** */
		private void OnArquivoLidoFaxineiro(object sender, EventArgs args){
			this.pbLeituraArquivo.Maximum = ((Faxineiro)sender).LinhasArquivo;
			Application.DoEvents();
		}
		
		private void OnArquivoLidoCarregador(object sender, EventArgs args){
			this.pbLeituraArquivo.Maximum += ((Carregador)sender).LinhasArquivo;
			Application.DoEvents();
		}
		
		private void OnLinhaLida(object sender, EventArgs args){
			this.pbLeituraArquivo.Value += 1;
			Application.DoEvents();
		}
		
		private void OnJogoAnalisadoMaiorSequencia(object sender, EventArgs args){
			this.pbMaiorSequencia.Value += 1;
			Application.DoEvents();

		}
		
		private void OnJogoAnalisadoEstiloSequencias(object sender, EventArgs args){
			this.pbSequencias.Value += 1;
			Application.DoEvents();
		}
		
		private void OnJogoAnalisadoEstiloSequenciasCompleta(object sender, EventArgs args){
			this.pbSequenciasCompletas.Value += 1;
			Application.DoEvents();

		}
		
		private void OnJogoAnalisadoMaiorIntervalo(object sender, EventArgs args){
			this.pbMaiorIntervalo.Value += 1;
			Application.DoEvents();

		}
		
		private void OnJogoAnalisadoImparPar(object sender, EventArgs args){
			this.pbImparPar.Value += 1;
			Application.DoEvents();
		}
		
		private void OnJogoAnalisadoEstiloImparPar(object sender, EventArgs args){
			this.pbEstiloImparPar.Value += 1;
			Application.DoEvents();
		}
		
		private void OnJogoReprovado(object sender, JogoReprovadoArgs args){
			MotivoReprovacao motivo = args.MotivoReprovacao;
			
			switch (motivo) {
				case MotivoReprovacao.COINCIDENCIA:
					lbCoincidencias.Text = ValidadorGeral.FATOR_COINCIDENCIA + "+ bolas coincidentes em outro jogo: " + gerador.RepCoincidencias.ToString("###,###,###,###,###,###,##0");
					break;
				case MotivoReprovacao.ESTILO:
					lbEstiloJogo.Text = "Estilo do jogo: " + gerador.RepEstilo.ToString("###,###,###,###,###,###,##0");
					break;
				case MotivoReprovacao.ESTILO_IMPAR_PAR:
					lbEstiloParesImpares.Text = "Estilo pares/ímpares: " + gerador.RepEstiloImparPar.ToString("###,###,###,###,###,###,##0");
					break;
				case MotivoReprovacao.EXISTENTE:
					lbJogoGerado.Text = "Jogo já sorteado ou gerado: " + gerador.RepExistente.ToString("###,###,###,###,###,###,##0");
					break;
				case MotivoReprovacao.INTERVALO:
					lbTamanhoIntervalo.Text = "Tamanho do intervalo: " + gerador.RepIntervalo.ToString("###,###,###,###,###,###,##0");
					break;
				case MotivoReprovacao.PARES_IMPARES:
					lbDistribuicaoParesImpares.Text = "Distribuição de pares e ímpares: " + gerador.RepParesImpares.ToString("###,###,###,###,###,###,##0");
					break;
				case MotivoReprovacao.SEQUENCIA:
					lbTamanhoSequencia.Text = "Tamanho da sequência: " + gerador.RepSequencia.ToString("###,###,###,###,###,###,##0");
					break;
			}
			Application.DoEvents();
		}
		
		private void OnJogoAprovado(object sender, JogoAprovadoArgs args) {
			Jogo jogo = args.Jogo;
			rtJogos.Text += "=====>" + jogo.ToString() + "<=====" + System.Environment.NewLine;
			rtJogos.Text += "[" + args.Validador.ToString() + "]" + System.Environment.NewLine  + System.Environment.NewLine  + System.Environment.NewLine;
			
			this.pbJogosValidos.Value += 1;
			Application.DoEvents();
		}
		
		private void OnBolaSorteada(object sender, EventArgs args){
			Application.DoEvents();
		}
		
		private void OnGerarJogo(object sender, EventArgs args){
			Application.DoEvents();
		}
		
		void BtnAnalisarClick(object sender, EventArgs e)
		{
			this.pbLeituraArquivo.Value = 0;
			this.pbLeituraArquivo.Maximum = 0;

			this.pbMaiorSequencia.Value = 0;
			this.pbMaiorSequencia.Maximum = 0;

			this.pbMaiorIntervalo.Value = 0;
			this.pbMaiorIntervalo.Maximum = 0;
			
			this.pbSequencias.Value = 0;
			this.pbSequencias.Maximum = 0;
			
			this.pbSequenciasCompletas.Value = 0;
			this.pbSequenciasCompletas.Maximum = 0;
			
			this.pbImparPar.Value = 0;
			this.pbImparPar.Maximum = 0;
			
			this.pbEstiloImparPar.Value = 0;
			this.pbEstiloImparPar.Maximum = 0;
			
			txtResultados.Text = "";

			List<Jogo> jogosPassados = null;
			
			try {
				if (chkLimparArquivo.Enabled) {
					banco.CarregarArquivo(chkLimparArquivo.Checked);
				}
				
				DateTime inicio = DateTime.Now;
				System.Diagnostics.Debug.WriteLine("Início: " + inicio.ToString("HH:m:s tt zz"));
				
				if (jogosPassados == null) {
					jogosPassados = banco.ObterJogosPassados();
				}
				
				this.pbMaiorSequencia.Maximum = jogosPassados.Count;
				this.pbMaiorIntervalo.Maximum = jogosPassados.Count;
				this.pbSequencias.Maximum = jogosPassados.Count;
				this.pbSequenciasCompletas.Maximum = jogosPassados.Count;
				this.pbImparPar.Maximum = jogosPassados.Count;
				this.pbEstiloImparPar.Maximum = jogosPassados.Count;
				
			
				AnalisadorMaioresSequencias anlMaiorSequencia = new AnalisadorMaioresSequencias();
				anlMaiorSequencia.OnJogoAnalisado += OnJogoAnalisadoMaiorSequencia;
			
				AnalisadorEstiloSequencias anlEstiloSequencia = new AnalisadorEstiloSequencias();
				anlEstiloSequencia.OnJogoAnalisado += OnJogoAnalisadoEstiloSequencias;
				
				AnalisadorMaioresIntervalos anlMaiorIntervalo = new AnalisadorMaioresIntervalos();
				anlMaiorIntervalo.OnJogoAnalisado += OnJogoAnalisadoMaiorIntervalo;
			
				AnalsadorEstiloSequenciasCompleto anlEstiloSequenciaCompleta = new AnalsadorEstiloSequenciasCompleto();
				anlEstiloSequenciaCompleta.OnJogoAnalisado += OnJogoAnalisadoEstiloSequenciasCompleta;
			
				AnalisadorImparPar anlImparPar = new AnalisadorImparPar();
				anlImparPar.OnJogoAnalisado += OnJogoAnalisadoImparPar;
			
				AnalisadorEstiloImparPar anlEstiloImparPar = new AnalisadorEstiloImparPar();
				anlEstiloImparPar.OnJogoAnalisado += OnJogoAnalisadoEstiloImparPar;
				
				IDictionaryEnumerator enumerator = null;

				anlMaiorSequencia.Analisar(jogosPassados);
				this.pbMaiorSequencia.Maximum += anlMaiorSequencia.Analise.Count;
				enumerator = (IDictionaryEnumerator)anlMaiorSequencia.Analise.GetEnumerator();
				txtResultados.Text += "************** Maiores sequências **************" + Environment.NewLine;
				while (enumerator.MoveNext()) {
					decimal jogos = (int)enumerator.Value;
					decimal percentual = jogos / jogosPassados.Count * 100;
					txtResultados.Text += enumerator.Key + " números seguidos: " + enumerator.Value + " jogos (" + percentual.ToString("#0.00") + "%)" + Environment.NewLine;
					pbMaiorSequencia.Value += 1;
					Application.DoEvents();
				}
				txtResultados.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine;

				anlEstiloSequencia.Analisar(jogosPassados);
				this.pbSequencias.Maximum += anlEstiloSequencia.Analise.Count;
				enumerator = (IDictionaryEnumerator)anlEstiloSequencia.Analise.GetEnumerator();
				txtResultados.Text += "************** Estilo sequências **************" + Environment.NewLine;
				while (enumerator.MoveNext()) {
					decimal jogos = (int)enumerator.Value;
					decimal percentual = jogos / jogosPassados.Count * 100;
					txtResultados.Text += enumerator.Key + ": " + enumerator.Value + " jogos (" + percentual.ToString("#0.00") + "%)" + Environment.NewLine;
					pbSequencias.Value += 1;
					Application.DoEvents();
				}
				txtResultados.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine;
				
				anlMaiorIntervalo.Analisar(jogosPassados);
				this.pbMaiorIntervalo.Maximum += anlMaiorIntervalo.Analise.Count;
				enumerator = (IDictionaryEnumerator)anlMaiorIntervalo.Analise.GetEnumerator();
				txtResultados.Text += "************** Maiores intervalos **************" + Environment.NewLine;
				while (enumerator.MoveNext()) {
					decimal jogos = (int)enumerator.Value;
					decimal percentual = jogos / jogosPassados.Count * 100;
					txtResultados.Text += enumerator.Key + " números: " + enumerator.Value + " jogos (" + percentual.ToString("#0.00") + "%)" + Environment.NewLine;
					pbMaiorIntervalo.Value += 1;
					Application.DoEvents();
				}
				txtResultados.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine;

				anlEstiloSequenciaCompleta.Analisar(jogosPassados);
				this.pbSequenciasCompletas.Maximum += anlEstiloSequenciaCompleta.Analise.Count;
				enumerator = (IDictionaryEnumerator)anlEstiloSequenciaCompleta.Analise.GetEnumerator();
				txtResultados.Text += "************** Estilo completo **************" + Environment.NewLine;
				while (enumerator.MoveNext()) {
					decimal jogos = (int)enumerator.Value;
					decimal percentual = jogos / jogosPassados.Count * 100;
					txtResultados.Text += enumerator.Key + ": " + enumerator.Value + " jogos (" + percentual.ToString("#0.00") + "%)" + Environment.NewLine;
					pbSequenciasCompletas.Value += 1;
					Application.DoEvents();
				}
				txtResultados.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine;

				anlImparPar.Analisar(jogosPassados);
				this.pbImparPar.Maximum += anlImparPar.Analise.Count;
				enumerator = (IDictionaryEnumerator)anlImparPar.Analise.GetEnumerator();
				txtResultados.Text += "************** Ímpar/par **************" + Environment.NewLine;
				while (enumerator.MoveNext()) {
					decimal jogos = (int)enumerator.Value;
					decimal percentual = jogos / jogosPassados.Count * 100;
					txtResultados.Text += enumerator.Key + ": " + enumerator.Value + " jogos (" + percentual.ToString("#0.00") + "%)" + Environment.NewLine;
					pbImparPar.Value += 1;
					Application.DoEvents();
				}
				txtResultados.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine;

				anlEstiloImparPar.Analisar(jogosPassados);
				this.pbEstiloImparPar.Maximum += anlEstiloImparPar.Analise.Count;
				enumerator = (IDictionaryEnumerator)anlEstiloImparPar.Analise.GetEnumerator();
				txtResultados.Text += "************** Estilo ímpar/par **************" + Environment.NewLine;
				while (enumerator.MoveNext()) {
					decimal jogos = (int)enumerator.Value;
					decimal percentual = jogos / jogosPassados.Count * 100;
					txtResultados.Text += enumerator.Key + ": " + enumerator.Value + " jogos (" + percentual.ToString("#0.00") + "%)" + Environment.NewLine;
					this.pbEstiloImparPar.Value += 1;
					Application.DoEvents();
				}
				txtResultados.Text += Environment.NewLine + Environment.NewLine + Environment.NewLine;
				
				DateTime fim = DateTime.Now;
				System.Diagnostics.Debug.WriteLine("Fim: " + fim.ToString("HH:m:s tt zz"));
				TimeSpan diferenca = fim - inicio;
				System.Diagnostics.Debug.WriteLine("Tempo: " + diferenca.ToString("g"));
				
			} catch (Exception ex) {
				System.Diagnostics.Debug.WriteLine(ex.StackTrace);
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void BtnGerarJogosClick(object sender, EventArgs e)
		{
			if (validadores.Count == 0) {
				MessageBox.Show("Adicione pelo menos uma regra de validação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			SalvarValidadores();
			
			this.pbLeituraArquivo.Value = 0;
			this.pbLeituraArquivo.Maximum = 0;
			this.pbJogosValidos.Value = 0;
			this.pbJogosValidos.Maximum = Convert.ToInt32(updQuantidade.Value);
			rtJogos.Text = "";
			gerador.ZerarContadores();

			try {
				gerador.Banco = this.banco;
				gerador.Validadores = validadores;
				gerador.GerarJogos(Convert.ToInt32(updQuantidade.Value), Convert.ToInt32(updNumBolas.Value));
				MessageBox.Show("Números gerados com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
			} catch (Exception ex) {
				System.Diagnostics.Debug.WriteLine(ex.StackTrace);
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void UpdImparesValueChanged(object sender, EventArgs e)
		{
			updPares.Value = 15 - updImpares.Value;
		}
		void UpdParesValueChanged(object sender, EventArgs e)
		{
			updImpares.Value = 15 - updPares.Value;
		}
		void BAdicionarRegraClick(object sender, EventArgs e)
		{
			// Adiciona à lista
			ValidadorGenerico validador = new ValidadorGenerico();
			validador.NumerosPares = Convert.ToInt32(updPares.Value);
			validador.MaiorSequencia = Convert.ToInt32(updMaiorSequencia.Value);
			validador.MaiorIntervalo = Convert.ToInt32(updMaiorIntervalo.Value);
			
			validadores.Add(validador);
			
			// Adiciona na lista visual
			ListViewItem item = new ListViewItem(validador.MaiorSequencia.ToString());
			item.SubItems.Add(validador.MaiorIntervalo.ToString());
			item.SubItems.Add(validador.NumerosPares.ToString());
			item.SubItems.Add((15 - validador.NumerosPares).ToString());
			item.Tag = validador;
			
			lvRegras.Items.Add(item);
		}
		void ExcluirRegraToolStripMenuItemClick(object sender, EventArgs e)
		{
			if ((lvRegras.SelectedItems == null) || ((lvRegras.SelectedItems.Count == 0)))
			{
				MessageBox.Show("Nenhuma regra selecionada para excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			foreach (ListViewItem item in lvRegras.SelectedItems) {
				validadores.Remove((ValidadorGenerico)item.Tag);
				lvRegras.Items.Remove(item);
			}
			
		}
		void MnuRegistrarSorteiosClick(object sender, EventArgs e)
		{
			FormAdicionaJogoSorteado form = new FormAdicionaJogoSorteado(banco);
			try {
				DialogResult result = form.ShowDialog(this);
				if (result == DialogResult.OK) {
					banco.AdicionarJogoPassado(form.Jogo);
					banco.Salvar();
				}
			} finally {
				
			}
		}
	}
}
