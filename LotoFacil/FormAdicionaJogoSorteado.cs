/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 20/11/2015
 * Time: 19:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

using LotoFacil.Classes;

namespace LotoFacil
{
	/// <summary>
	/// Description of FormAdicionaJogoSorteado.
	/// </summary>
	public partial class FormAdicionaJogoSorteado : Form
	{
		// Campos
		private Jogo jogo = new Jogo();
		private BancoDados.BancoDados banco;
		private List<Jogo> gerados;
		private List<Jogo> reprovados;
		private DateTime ultimaGeracao;
		
		public Jogo Jogo
		{
			get{
				return jogo;
			}
		}
		
		public FormAdicionaJogoSorteado(BancoDados.BancoDados banco)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.banco = banco;
			gerados = banco.ObterJogosGerados();
			reprovados = banco.ObterJogosReprovados();
			
			ultimaGeracao = gerados[gerados.Count - 1].Data;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BAdicionarClick(object sender, EventArgs e)
		{
			jogo.Numero = Convert.ToInt32(numConcurso.Value);
			jogo.Data = dtpDataSorteio.Value;
			jogo.Bola01 = Convert.ToInt32(numBola01.Value);
			jogo.Bola02 = Convert.ToInt32(numBola02.Value);
			jogo.Bola03 = Convert.ToInt32(numBola03.Value);
			jogo.Bola04 = Convert.ToInt32(numBola04.Value);
			jogo.Bola05 = Convert.ToInt32(numBola05.Value);
			jogo.Bola06 = Convert.ToInt32(numBola06.Value);
			jogo.Bola07 = Convert.ToInt32(numBola07.Value);
			jogo.Bola08 = Convert.ToInt32(numBola08.Value);
			jogo.Bola09 = Convert.ToInt32(numBola09.Value);
			jogo.Bola10 = Convert.ToInt32(numBola10.Value);
			jogo.Bola11 = Convert.ToInt32(numBola11.Value);
			jogo.Bola12 = Convert.ToInt32(numBola12.Value);
			jogo.Bola13 = Convert.ToInt32(numBola13.Value);
			jogo.Bola14 = Convert.ToInt32(numBola14.Value);
			jogo.Bola15 = Convert.ToInt32(numBola15.Value);

			jogo.AnalisarJogo();
			this.DialogResult = DialogResult.OK;
		}
		void BCancelarClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
		void NumBola01ValueChanged(object sender, EventArgs e)
		{
			jogo.Bola01 = Convert.ToInt32(numBola01.Value);
			jogo.Bola02 = Convert.ToInt32(numBola02.Value);
			jogo.Bola03 = Convert.ToInt32(numBola03.Value);
			jogo.Bola04 = Convert.ToInt32(numBola04.Value);
			jogo.Bola05 = Convert.ToInt32(numBola05.Value);
			jogo.Bola06 = Convert.ToInt32(numBola06.Value);
			jogo.Bola07 = Convert.ToInt32(numBola07.Value);
			jogo.Bola08 = Convert.ToInt32(numBola08.Value);
			jogo.Bola09 = Convert.ToInt32(numBola09.Value);
			jogo.Bola10 = Convert.ToInt32(numBola10.Value);
			jogo.Bola11 = Convert.ToInt32(numBola11.Value);
			jogo.Bola12 = Convert.ToInt32(numBola12.Value);
			jogo.Bola13 = Convert.ToInt32(numBola13.Value);
			jogo.Bola14 = Convert.ToInt32(numBola14.Value);
			jogo.Bola15 = Convert.ToInt32(numBola15.Value);

			jogo.Bolas.Clear();
			jogo.Bolas.Add(jogo.Bola01);
			jogo.Bolas.Add(jogo.Bola02);
			jogo.Bolas.Add(jogo.Bola03);
			jogo.Bolas.Add(jogo.Bola04);
			jogo.Bolas.Add(jogo.Bola05);
			jogo.Bolas.Add(jogo.Bola06);
			jogo.Bolas.Add(jogo.Bola07);
			jogo.Bolas.Add(jogo.Bola08);
			jogo.Bolas.Add(jogo.Bola09);
			jogo.Bolas.Add(jogo.Bola10);
			jogo.Bolas.Add(jogo.Bola11);
			jogo.Bolas.Add(jogo.Bola12);
			jogo.Bolas.Add(jogo.Bola13);
			jogo.Bolas.Add(jogo.Bola14);
			jogo.Bolas.Add(jogo.Bola15);
			
			txtAnalise.Text = "";

			for (int i = 7; i <= 15; i++){
				txtAnalise.Text += "***** " + i + " pontos *****" + Environment.NewLine;
				// Verifica número máximo de coincidências nos gerados
				var coincideGerados = from j in gerados
					where (j.SequenciaCoincidente(jogo.ToString()) == i)
					&& (j.Data >= new DateTime(ultimaGeracao.Year, ultimaGeracao.Month, ultimaGeracao.Day, 0, 0, 0))
					&& (j.Data <= new DateTime(ultimaGeracao.Year, ultimaGeracao.Month, ultimaGeracao.Day, 23, 59, 59))
					select j;
				txtAnalise.Text += "Gerados: "  + coincideGerados.Count() + " jogo(s)" + Environment.NewLine;
				// Verifica número máximo de coincidências nos reprovados
				var coincideReprovados = from j in reprovados
					where (j.SequenciaCoincidente(jogo.ToString()) == i)
					&& (j.Data >= new DateTime(ultimaGeracao.Year, ultimaGeracao.Month, ultimaGeracao.Day, 0, 0, 0))
					&& (j.Data <= new DateTime(ultimaGeracao.Year, ultimaGeracao.Month, ultimaGeracao.Day, 23, 59, 59))
					select j;
				txtAnalise.Text += "Reprovados: "  + coincideReprovados.Count() + " jogo(s)" + Environment.NewLine;
			}
		}
	}
}
