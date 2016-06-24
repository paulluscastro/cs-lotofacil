/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 02/10/2015
 * Time: 13:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LotoFacil
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lbTitulo = new System.Windows.Forms.Label();
			this.chkLimparArquivo = new System.Windows.Forms.CheckBox();
			this.btnAnalisar = new System.Windows.Forms.Button();
			this.tcOpcoes = new System.Windows.Forms.TabControl();
			this.tpAnalise = new System.Windows.Forms.TabPage();
			this.pbEstiloImparPar = new System.Windows.Forms.ProgressBar();
			this.lbEstiloImparPar = new System.Windows.Forms.Label();
			this.pbImparPar = new System.Windows.Forms.ProgressBar();
			this.lbImparPar = new System.Windows.Forms.Label();
			this.txtResultados = new System.Windows.Forms.TextBox();
			this.lbResultados = new System.Windows.Forms.Label();
			this.pbSequenciasCompletas = new System.Windows.Forms.ProgressBar();
			this.lbSequenciasCompletas = new System.Windows.Forms.Label();
			this.pbMaiorIntervalo = new System.Windows.Forms.ProgressBar();
			this.lbMaiorIntervalo = new System.Windows.Forms.Label();
			this.pbSequencias = new System.Windows.Forms.ProgressBar();
			this.lbSequencias = new System.Windows.Forms.Label();
			this.pbMaiorSequencia = new System.Windows.Forms.ProgressBar();
			this.lbMaiorSequencia = new System.Windows.Forms.Label();
			this.tpGerador = new System.Windows.Forms.TabPage();
			this.rtJogos = new System.Windows.Forms.RichTextBox();
			this.lbTotalReprovados = new System.Windows.Forms.Label();
			this.lbCoincidencias = new System.Windows.Forms.Label();
			this.lbJogoGerado = new System.Windows.Forms.Label();
			this.lbEstiloParesImpares = new System.Windows.Forms.Label();
			this.lbEstiloJogo = new System.Windows.Forms.Label();
			this.lbTamanhoSequencia = new System.Windows.Forms.Label();
			this.lbTamanhoIntervalo = new System.Windows.Forms.Label();
			this.lbDistribuicaoParesImpares = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbJogosReprovados = new System.Windows.Forms.Label();
			this.pbJogosValidos = new System.Windows.Forms.ProgressBar();
			this.lbJogosGerados = new System.Windows.Forms.Label();
			this.gbConfiguracoes = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.updNumBolas = new System.Windows.Forms.NumericUpDown();
			this.lvRegras = new System.Windows.Forms.ListView();
			this.colMaiorSequencia = new System.Windows.Forms.ColumnHeader();
			this.colMaiorIntervalo = new System.Windows.Forms.ColumnHeader();
			this.colPares = new System.Windows.Forms.ColumnHeader();
			this.colImpares = new System.Windows.Forms.ColumnHeader();
			this.ctxRegras = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.excluirRegraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bAdicionarRegra = new System.Windows.Forms.Button();
			this.updPares = new System.Windows.Forms.NumericUpDown();
			this.lbPares = new System.Windows.Forms.Label();
			this.updImpares = new System.Windows.Forms.NumericUpDown();
			this.lbImpares = new System.Windows.Forms.Label();
			this.updMaiorIntervalo = new System.Windows.Forms.NumericUpDown();
			this.updQuantidade = new System.Windows.Forms.NumericUpDown();
			this.lbConfMaiorIntervalo = new System.Windows.Forms.Label();
			this.btnGerarJogos = new System.Windows.Forms.Button();
			this.updMaiorSequencia = new System.Windows.Forms.NumericUpDown();
			this.lbConfMaiorSequencia = new System.Windows.Forms.Label();
			this.pbLeituraArquivo = new System.Windows.Forms.ProgressBar();
			this.lbLeitura = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.jogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRegistrarSorteios = new System.Windows.Forms.ToolStripMenuItem();
			this.visualizarJogosGeradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tcOpcoes.SuspendLayout();
			this.tpAnalise.SuspendLayout();
			this.tpGerador.SuspendLayout();
			this.gbConfiguracoes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.updNumBolas)).BeginInit();
			this.ctxRegras.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.updPares)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.updImpares)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.updMaiorIntervalo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.updQuantidade)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.updMaiorSequencia)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbTitulo
			// 
			this.lbTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.lbTitulo.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.lbTitulo.Location = new System.Drawing.Point(12, 24);
			this.lbTitulo.Name = "lbTitulo";
			this.lbTitulo.Size = new System.Drawing.Size(545, 28);
			this.lbTitulo.TabIndex = 0;
			this.lbTitulo.Text = "GERADOR DE JOGOS LOTOFÁCIL";
			this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chkLimparArquivo
			// 
			this.chkLimparArquivo.Location = new System.Drawing.Point(12, 55);
			this.chkLimparArquivo.Name = "chkLimparArquivo";
			this.chkLimparArquivo.Size = new System.Drawing.Size(102, 24);
			this.chkLimparArquivo.TabIndex = 0;
			this.chkLimparArquivo.Text = "Limpar arquivo";
			this.chkLimparArquivo.UseVisualStyleBackColor = true;
			// 
			// btnAnalisar
			// 
			this.btnAnalisar.Location = new System.Drawing.Point(6, 6);
			this.btnAnalisar.Name = "btnAnalisar";
			this.btnAnalisar.Size = new System.Drawing.Size(102, 23);
			this.btnAnalisar.TabIndex = 1;
			this.btnAnalisar.Text = "Analisar histórico";
			this.btnAnalisar.UseVisualStyleBackColor = true;
			this.btnAnalisar.Click += new System.EventHandler(this.BtnAnalisarClick);
			// 
			// tcOpcoes
			// 
			this.tcOpcoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.tcOpcoes.Controls.Add(this.tpAnalise);
			this.tcOpcoes.Controls.Add(this.tpGerador);
			this.tcOpcoes.Location = new System.Drawing.Point(12, 136);
			this.tcOpcoes.Name = "tcOpcoes";
			this.tcOpcoes.SelectedIndex = 0;
			this.tcOpcoes.Size = new System.Drawing.Size(545, 443);
			this.tcOpcoes.TabIndex = 2;
			// 
			// tpAnalise
			// 
			this.tpAnalise.Controls.Add(this.pbEstiloImparPar);
			this.tpAnalise.Controls.Add(this.lbEstiloImparPar);
			this.tpAnalise.Controls.Add(this.pbImparPar);
			this.tpAnalise.Controls.Add(this.lbImparPar);
			this.tpAnalise.Controls.Add(this.txtResultados);
			this.tpAnalise.Controls.Add(this.lbResultados);
			this.tpAnalise.Controls.Add(this.pbSequenciasCompletas);
			this.tpAnalise.Controls.Add(this.lbSequenciasCompletas);
			this.tpAnalise.Controls.Add(this.pbMaiorIntervalo);
			this.tpAnalise.Controls.Add(this.lbMaiorIntervalo);
			this.tpAnalise.Controls.Add(this.pbSequencias);
			this.tpAnalise.Controls.Add(this.lbSequencias);
			this.tpAnalise.Controls.Add(this.pbMaiorSequencia);
			this.tpAnalise.Controls.Add(this.lbMaiorSequencia);
			this.tpAnalise.Controls.Add(this.btnAnalisar);
			this.tpAnalise.Location = new System.Drawing.Point(4, 22);
			this.tpAnalise.Name = "tpAnalise";
			this.tpAnalise.Padding = new System.Windows.Forms.Padding(3);
			this.tpAnalise.Size = new System.Drawing.Size(537, 417);
			this.tpAnalise.TabIndex = 0;
			this.tpAnalise.Text = "Análise de histórico";
			this.tpAnalise.UseVisualStyleBackColor = true;
			// 
			// pbEstiloImparPar
			// 
			this.pbEstiloImparPar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pbEstiloImparPar.Location = new System.Drawing.Point(272, 159);
			this.pbEstiloImparPar.Name = "pbEstiloImparPar";
			this.pbEstiloImparPar.Size = new System.Drawing.Size(259, 23);
			this.pbEstiloImparPar.TabIndex = 15;
			// 
			// lbEstiloImparPar
			// 
			this.lbEstiloImparPar.AutoSize = true;
			this.lbEstiloImparPar.Location = new System.Drawing.Point(272, 143);
			this.lbEstiloImparPar.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbEstiloImparPar.Name = "lbEstiloImparPar";
			this.lbEstiloImparPar.Size = new System.Drawing.Size(82, 13);
			this.lbEstiloImparPar.TabIndex = 14;
			this.lbEstiloImparPar.Text = "Estilo ímpar/par";
			// 
			// pbImparPar
			// 
			this.pbImparPar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pbImparPar.Location = new System.Drawing.Point(6, 159);
			this.pbImparPar.Name = "pbImparPar";
			this.pbImparPar.Size = new System.Drawing.Size(259, 23);
			this.pbImparPar.TabIndex = 13;
			// 
			// lbImparPar
			// 
			this.lbImparPar.AutoSize = true;
			this.lbImparPar.Location = new System.Drawing.Point(6, 143);
			this.lbImparPar.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbImparPar.Name = "lbImparPar";
			this.lbImparPar.Size = new System.Drawing.Size(120, 13);
			this.lbImparPar.TabIndex = 12;
			this.lbImparPar.Text = "Análise ímpares e pares";
			// 
			// txtResultados
			// 
			this.txtResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.txtResultados.Location = new System.Drawing.Point(6, 210);
			this.txtResultados.Multiline = true;
			this.txtResultados.Name = "txtResultados";
			this.txtResultados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtResultados.Size = new System.Drawing.Size(525, 196);
			this.txtResultados.TabIndex = 11;
			// 
			// lbResultados
			// 
			this.lbResultados.AutoSize = true;
			this.lbResultados.Location = new System.Drawing.Point(6, 194);
			this.lbResultados.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbResultados.Name = "lbResultados";
			this.lbResultados.Size = new System.Drawing.Size(116, 13);
			this.lbResultados.TabIndex = 10;
			this.lbResultados.Text = "Resultado das análises";
			// 
			// pbSequenciasCompletas
			// 
			this.pbSequenciasCompletas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pbSequenciasCompletas.Location = new System.Drawing.Point(272, 108);
			this.pbSequenciasCompletas.Name = "pbSequenciasCompletas";
			this.pbSequenciasCompletas.Size = new System.Drawing.Size(259, 23);
			this.pbSequenciasCompletas.TabIndex = 9;
			// 
			// lbSequenciasCompletas
			// 
			this.lbSequenciasCompletas.AutoSize = true;
			this.lbSequenciasCompletas.Location = new System.Drawing.Point(272, 92);
			this.lbSequenciasCompletas.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbSequenciasCompletas.Name = "lbSequenciasCompletas";
			this.lbSequenciasCompletas.Size = new System.Drawing.Size(155, 13);
			this.lbSequenciasCompletas.TabIndex = 8;
			this.lbSequenciasCompletas.Text = "Estilo de sequências completas";
			// 
			// pbMaiorIntervalo
			// 
			this.pbMaiorIntervalo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pbMaiorIntervalo.Location = new System.Drawing.Point(6, 108);
			this.pbMaiorIntervalo.Name = "pbMaiorIntervalo";
			this.pbMaiorIntervalo.Size = new System.Drawing.Size(259, 23);
			this.pbMaiorIntervalo.TabIndex = 7;
			// 
			// lbMaiorIntervalo
			// 
			this.lbMaiorIntervalo.AutoSize = true;
			this.lbMaiorIntervalo.Location = new System.Drawing.Point(6, 92);
			this.lbMaiorIntervalo.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbMaiorIntervalo.Name = "lbMaiorIntervalo";
			this.lbMaiorIntervalo.Size = new System.Drawing.Size(127, 13);
			this.lbMaiorIntervalo.TabIndex = 6;
			this.lbMaiorIntervalo.Text = "Análise do maior intervalo";
			// 
			// pbSequencias
			// 
			this.pbSequencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pbSequencias.Location = new System.Drawing.Point(272, 57);
			this.pbSequencias.Name = "pbSequencias";
			this.pbSequencias.Size = new System.Drawing.Size(259, 23);
			this.pbSequencias.TabIndex = 5;
			// 
			// lbSequencias
			// 
			this.lbSequencias.AutoSize = true;
			this.lbSequencias.Location = new System.Drawing.Point(272, 41);
			this.lbSequencias.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbSequencias.Name = "lbSequencias";
			this.lbSequencias.Size = new System.Drawing.Size(104, 13);
			this.lbSequencias.TabIndex = 4;
			this.lbSequencias.Text = "Estilo de sequências";
			// 
			// pbMaiorSequencia
			// 
			this.pbMaiorSequencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pbMaiorSequencia.Location = new System.Drawing.Point(6, 57);
			this.pbMaiorSequencia.Name = "pbMaiorSequencia";
			this.pbMaiorSequencia.Size = new System.Drawing.Size(259, 23);
			this.pbMaiorSequencia.TabIndex = 3;
			// 
			// lbMaiorSequencia
			// 
			this.lbMaiorSequencia.AutoSize = true;
			this.lbMaiorSequencia.Location = new System.Drawing.Point(6, 41);
			this.lbMaiorSequencia.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbMaiorSequencia.Name = "lbMaiorSequencia";
			this.lbMaiorSequencia.Size = new System.Drawing.Size(136, 13);
			this.lbMaiorSequencia.TabIndex = 2;
			this.lbMaiorSequencia.Text = "Análise da maior sequencia";
			// 
			// tpGerador
			// 
			this.tpGerador.Controls.Add(this.rtJogos);
			this.tpGerador.Controls.Add(this.lbTotalReprovados);
			this.tpGerador.Controls.Add(this.lbCoincidencias);
			this.tpGerador.Controls.Add(this.lbJogoGerado);
			this.tpGerador.Controls.Add(this.lbEstiloParesImpares);
			this.tpGerador.Controls.Add(this.lbEstiloJogo);
			this.tpGerador.Controls.Add(this.lbTamanhoSequencia);
			this.tpGerador.Controls.Add(this.lbTamanhoIntervalo);
			this.tpGerador.Controls.Add(this.lbDistribuicaoParesImpares);
			this.tpGerador.Controls.Add(this.label2);
			this.tpGerador.Controls.Add(this.lbJogosReprovados);
			this.tpGerador.Controls.Add(this.pbJogosValidos);
			this.tpGerador.Controls.Add(this.lbJogosGerados);
			this.tpGerador.Controls.Add(this.gbConfiguracoes);
			this.tpGerador.Location = new System.Drawing.Point(4, 22);
			this.tpGerador.Name = "tpGerador";
			this.tpGerador.Padding = new System.Windows.Forms.Padding(3);
			this.tpGerador.Size = new System.Drawing.Size(537, 417);
			this.tpGerador.TabIndex = 1;
			this.tpGerador.Text = "Gerador de jogos";
			this.tpGerador.UseVisualStyleBackColor = true;
			// 
			// rtJogos
			// 
			this.rtJogos.Location = new System.Drawing.Point(6, 324);
			this.rtJogos.Name = "rtJogos";
			this.rtJogos.ReadOnly = true;
			this.rtJogos.Size = new System.Drawing.Size(525, 87);
			this.rtJogos.TabIndex = 18;
			this.rtJogos.Text = "";
			// 
			// lbTotalReprovados
			// 
			this.lbTotalReprovados.Location = new System.Drawing.Point(308, 308);
			this.lbTotalReprovados.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbTotalReprovados.Name = "lbTotalReprovados";
			this.lbTotalReprovados.Size = new System.Drawing.Size(223, 13);
			this.lbTotalReprovados.TabIndex = 17;
			this.lbTotalReprovados.Text = "0";
			this.lbTotalReprovados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbCoincidencias
			// 
			this.lbCoincidencias.Location = new System.Drawing.Point(6, 308);
			this.lbCoincidencias.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbCoincidencias.Name = "lbCoincidencias";
			this.lbCoincidencias.Size = new System.Drawing.Size(259, 13);
			this.lbCoincidencias.TabIndex = 16;
			this.lbCoincidencias.Text = "9+ bolas coincidentes em outro jogo: 0";
			this.lbCoincidencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbJogoGerado
			// 
			this.lbJogoGerado.Location = new System.Drawing.Point(272, 264);
			this.lbJogoGerado.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbJogoGerado.Name = "lbJogoGerado";
			this.lbJogoGerado.Size = new System.Drawing.Size(259, 13);
			this.lbJogoGerado.TabIndex = 15;
			this.lbJogoGerado.Text = "Jogo já sorteado ou gerado: 0";
			this.lbJogoGerado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbEstiloParesImpares
			// 
			this.lbEstiloParesImpares.Location = new System.Drawing.Point(6, 286);
			this.lbEstiloParesImpares.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbEstiloParesImpares.Name = "lbEstiloParesImpares";
			this.lbEstiloParesImpares.Size = new System.Drawing.Size(259, 13);
			this.lbEstiloParesImpares.TabIndex = 14;
			this.lbEstiloParesImpares.Text = "Estilo pares/ímpares: 0";
			this.lbEstiloParesImpares.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbEstiloJogo
			// 
			this.lbEstiloJogo.Location = new System.Drawing.Point(272, 242);
			this.lbEstiloJogo.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbEstiloJogo.Name = "lbEstiloJogo";
			this.lbEstiloJogo.Size = new System.Drawing.Size(259, 13);
			this.lbEstiloJogo.TabIndex = 13;
			this.lbEstiloJogo.Text = "Estilo do jogo: 0";
			this.lbEstiloJogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbTamanhoSequencia
			// 
			this.lbTamanhoSequencia.Location = new System.Drawing.Point(6, 264);
			this.lbTamanhoSequencia.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbTamanhoSequencia.Name = "lbTamanhoSequencia";
			this.lbTamanhoSequencia.Size = new System.Drawing.Size(259, 13);
			this.lbTamanhoSequencia.TabIndex = 12;
			this.lbTamanhoSequencia.Text = "Tamanho da sequência: 0";
			this.lbTamanhoSequencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbTamanhoIntervalo
			// 
			this.lbTamanhoIntervalo.Location = new System.Drawing.Point(6, 242);
			this.lbTamanhoIntervalo.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbTamanhoIntervalo.Name = "lbTamanhoIntervalo";
			this.lbTamanhoIntervalo.Size = new System.Drawing.Size(259, 13);
			this.lbTamanhoIntervalo.TabIndex = 11;
			this.lbTamanhoIntervalo.Text = "Tamanho do intervalo: 0";
			this.lbTamanhoIntervalo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbDistribuicaoParesImpares
			// 
			this.lbDistribuicaoParesImpares.Location = new System.Drawing.Point(272, 286);
			this.lbDistribuicaoParesImpares.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbDistribuicaoParesImpares.Name = "lbDistribuicaoParesImpares";
			this.lbDistribuicaoParesImpares.Size = new System.Drawing.Size(259, 13);
			this.lbDistribuicaoParesImpares.TabIndex = 10;
			this.lbDistribuicaoParesImpares.Text = "Distribuição de pares e ímpares: 0";
			this.lbDistribuicaoParesImpares.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 208);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(525, 28);
			this.label2.TabIndex = 9;
			this.label2.Text = "ESTATÍSTICAS DE REPROVAÇÃO";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbJogosReprovados
			// 
			this.lbJogosReprovados.AutoSize = true;
			this.lbJogosReprovados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbJogosReprovados.Location = new System.Drawing.Point(268, 308);
			this.lbJogosReprovados.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbJogosReprovados.Name = "lbJogosReprovados";
			this.lbJogosReprovados.Size = new System.Drawing.Size(40, 13);
			this.lbJogosReprovados.TabIndex = 7;
			this.lbJogosReprovados.Text = "Total:";
			this.lbJogosReprovados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pbJogosValidos
			// 
			this.pbJogosValidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pbJogosValidos.Location = new System.Drawing.Point(6, 182);
			this.pbJogosValidos.Name = "pbJogosValidos";
			this.pbJogosValidos.Size = new System.Drawing.Size(525, 23);
			this.pbJogosValidos.TabIndex = 6;
			// 
			// lbJogosGerados
			// 
			this.lbJogosGerados.AutoSize = true;
			this.lbJogosGerados.Location = new System.Drawing.Point(6, 166);
			this.lbJogosGerados.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbJogosGerados.Name = "lbJogosGerados";
			this.lbJogosGerados.Size = new System.Drawing.Size(76, 13);
			this.lbJogosGerados.TabIndex = 3;
			this.lbJogosGerados.Text = "Jogos gerados";
			// 
			// gbConfiguracoes
			// 
			this.gbConfiguracoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.gbConfiguracoes.Controls.Add(this.label3);
			this.gbConfiguracoes.Controls.Add(this.label1);
			this.gbConfiguracoes.Controls.Add(this.updNumBolas);
			this.gbConfiguracoes.Controls.Add(this.lvRegras);
			this.gbConfiguracoes.Controls.Add(this.bAdicionarRegra);
			this.gbConfiguracoes.Controls.Add(this.updPares);
			this.gbConfiguracoes.Controls.Add(this.lbPares);
			this.gbConfiguracoes.Controls.Add(this.updImpares);
			this.gbConfiguracoes.Controls.Add(this.lbImpares);
			this.gbConfiguracoes.Controls.Add(this.updMaiorIntervalo);
			this.gbConfiguracoes.Controls.Add(this.updQuantidade);
			this.gbConfiguracoes.Controls.Add(this.lbConfMaiorIntervalo);
			this.gbConfiguracoes.Controls.Add(this.btnGerarJogos);
			this.gbConfiguracoes.Controls.Add(this.updMaiorSequencia);
			this.gbConfiguracoes.Controls.Add(this.lbConfMaiorSequencia);
			this.gbConfiguracoes.Location = new System.Drawing.Point(6, 6);
			this.gbConfiguracoes.Name = "gbConfiguracoes";
			this.gbConfiguracoes.Size = new System.Drawing.Size(525, 148);
			this.gbConfiguracoes.TabIndex = 1;
			this.gbConfiguracoes.TabStop = false;
			this.gbConfiguracoes.Text = "Configurações";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(377, 106);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Qtd Jogos";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(318, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "Qtd Bolas";
			// 
			// updNumBolas
			// 
			this.updNumBolas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.updNumBolas.Location = new System.Drawing.Point(318, 122);
			this.updNumBolas.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
			this.updNumBolas.Maximum = new decimal(new int[] {
			18,
			0,
			0,
			0});
			this.updNumBolas.Minimum = new decimal(new int[] {
			15,
			0,
			0,
			0});
			this.updNumBolas.Name = "updNumBolas";
			this.updNumBolas.Size = new System.Drawing.Size(51, 20);
			this.updNumBolas.TabIndex = 11;
			this.updNumBolas.Value = new decimal(new int[] {
			15,
			0,
			0,
			0});
			// 
			// lvRegras
			// 
			this.lvRegras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.colMaiorSequencia,
			this.colMaiorIntervalo,
			this.colPares,
			this.colImpares});
			this.lvRegras.ContextMenuStrip = this.ctxRegras;
			this.lvRegras.FullRowSelect = true;
			this.lvRegras.Location = new System.Drawing.Point(6, 67);
			this.lvRegras.Name = "lvRegras";
			this.lvRegras.Size = new System.Drawing.Size(300, 75);
			this.lvRegras.TabIndex = 10;
			this.lvRegras.UseCompatibleStateImageBehavior = false;
			this.lvRegras.View = System.Windows.Forms.View.Details;
			// 
			// colMaiorSequencia
			// 
			this.colMaiorSequencia.Text = "Maior sequência";
			this.colMaiorSequencia.Width = 90;
			// 
			// colMaiorIntervalo
			// 
			this.colMaiorIntervalo.Text = "Maior intervalo";
			this.colMaiorIntervalo.Width = 85;
			// 
			// colPares
			// 
			this.colPares.Text = "Pares";
			this.colPares.Width = 40;
			// 
			// colImpares
			// 
			this.colImpares.Text = "Ímpares";
			// 
			// ctxRegras
			// 
			this.ctxRegras.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.excluirRegraToolStripMenuItem});
			this.ctxRegras.Name = "ctxRegras";
			this.ctxRegras.Size = new System.Drawing.Size(139, 26);
			// 
			// excluirRegraToolStripMenuItem
			// 
			this.excluirRegraToolStripMenuItem.Name = "excluirRegraToolStripMenuItem";
			this.excluirRegraToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
			this.excluirRegraToolStripMenuItem.Text = "Excluir regra";
			this.excluirRegraToolStripMenuItem.Click += new System.EventHandler(this.ExcluirRegraToolStripMenuItemClick);
			// 
			// bAdicionarRegra
			// 
			this.bAdicionarRegra.Location = new System.Drawing.Point(318, 38);
			this.bAdicionarRegra.Name = "bAdicionarRegra";
			this.bAdicionarRegra.Size = new System.Drawing.Size(201, 23);
			this.bAdicionarRegra.TabIndex = 9;
			this.bAdicionarRegra.Text = "Adicionar regra de validação";
			this.bAdicionarRegra.UseVisualStyleBackColor = true;
			this.bAdicionarRegra.Click += new System.EventHandler(this.BAdicionarRegraClick);
			// 
			// updPares
			// 
			this.updPares.Location = new System.Drawing.Point(206, 41);
			this.updPares.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
			this.updPares.Name = "updPares";
			this.updPares.Size = new System.Drawing.Size(44, 20);
			this.updPares.TabIndex = 8;
			this.updPares.Value = new decimal(new int[] {
			8,
			0,
			0,
			0});
			this.updPares.ValueChanged += new System.EventHandler(this.UpdParesValueChanged);
			// 
			// lbPares
			// 
			this.lbPares.AutoSize = true;
			this.lbPares.Location = new System.Drawing.Point(206, 25);
			this.lbPares.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbPares.Name = "lbPares";
			this.lbPares.Size = new System.Drawing.Size(34, 13);
			this.lbPares.TabIndex = 7;
			this.lbPares.Text = "Pares";
			// 
			// updImpares
			// 
			this.updImpares.Location = new System.Drawing.Point(262, 41);
			this.updImpares.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
			this.updImpares.Name = "updImpares";
			this.updImpares.Size = new System.Drawing.Size(44, 20);
			this.updImpares.TabIndex = 6;
			this.updImpares.Value = new decimal(new int[] {
			7,
			0,
			0,
			0});
			this.updImpares.ValueChanged += new System.EventHandler(this.UpdImparesValueChanged);
			// 
			// lbImpares
			// 
			this.lbImpares.AutoSize = true;
			this.lbImpares.Location = new System.Drawing.Point(262, 25);
			this.lbImpares.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbImpares.Name = "lbImpares";
			this.lbImpares.Size = new System.Drawing.Size(44, 13);
			this.lbImpares.TabIndex = 5;
			this.lbImpares.Text = "Ímpares";
			// 
			// updMaiorIntervalo
			// 
			this.updMaiorIntervalo.Location = new System.Drawing.Point(109, 41);
			this.updMaiorIntervalo.Margin = new System.Windows.Forms.Padding(9, 3, 9, 3);
			this.updMaiorIntervalo.Name = "updMaiorIntervalo";
			this.updMaiorIntervalo.Size = new System.Drawing.Size(85, 20);
			this.updMaiorIntervalo.TabIndex = 3;
			this.updMaiorIntervalo.Value = new decimal(new int[] {
			4,
			0,
			0,
			0});
			// 
			// updQuantidade
			// 
			this.updQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.updQuantidade.Location = new System.Drawing.Point(381, 122);
			this.updQuantidade.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
			this.updQuantidade.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.updQuantidade.Name = "updQuantidade";
			this.updQuantidade.Size = new System.Drawing.Size(51, 20);
			this.updQuantidade.TabIndex = 4;
			this.updQuantidade.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// lbConfMaiorIntervalo
			// 
			this.lbConfMaiorIntervalo.AutoSize = true;
			this.lbConfMaiorIntervalo.Location = new System.Drawing.Point(109, 25);
			this.lbConfMaiorIntervalo.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbConfMaiorIntervalo.Name = "lbConfMaiorIntervalo";
			this.lbConfMaiorIntervalo.Size = new System.Drawing.Size(76, 13);
			this.lbConfMaiorIntervalo.TabIndex = 2;
			this.lbConfMaiorIntervalo.Text = "Maior intervalo";
			// 
			// btnGerarJogos
			// 
			this.btnGerarJogos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGerarJogos.Location = new System.Drawing.Point(444, 119);
			this.btnGerarJogos.Name = "btnGerarJogos";
			this.btnGerarJogos.Size = new System.Drawing.Size(75, 23);
			this.btnGerarJogos.TabIndex = 2;
			this.btnGerarJogos.Text = "Gerar Jogos";
			this.btnGerarJogos.UseVisualStyleBackColor = true;
			this.btnGerarJogos.Click += new System.EventHandler(this.BtnGerarJogosClick);
			// 
			// updMaiorSequencia
			// 
			this.updMaiorSequencia.Location = new System.Drawing.Point(6, 41);
			this.updMaiorSequencia.Margin = new System.Windows.Forms.Padding(3, 3, 9, 3);
			this.updMaiorSequencia.Name = "updMaiorSequencia";
			this.updMaiorSequencia.Size = new System.Drawing.Size(85, 20);
			this.updMaiorSequencia.TabIndex = 1;
			this.updMaiorSequencia.Value = new decimal(new int[] {
			4,
			0,
			0,
			0});
			// 
			// lbConfMaiorSequencia
			// 
			this.lbConfMaiorSequencia.AutoSize = true;
			this.lbConfMaiorSequencia.Location = new System.Drawing.Point(6, 25);
			this.lbConfMaiorSequencia.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbConfMaiorSequencia.Name = "lbConfMaiorSequencia";
			this.lbConfMaiorSequencia.Size = new System.Drawing.Size(85, 13);
			this.lbConfMaiorSequencia.TabIndex = 0;
			this.lbConfMaiorSequencia.Text = "Maior sequência";
			// 
			// pbLeituraArquivo
			// 
			this.pbLeituraArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pbLeituraArquivo.Location = new System.Drawing.Point(12, 107);
			this.pbLeituraArquivo.Name = "pbLeituraArquivo";
			this.pbLeituraArquivo.Size = new System.Drawing.Size(545, 23);
			this.pbLeituraArquivo.TabIndex = 13;
			// 
			// lbLeitura
			// 
			this.lbLeitura.AutoSize = true;
			this.lbLeitura.Location = new System.Drawing.Point(12, 91);
			this.lbLeitura.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
			this.lbLeitura.Name = "lbLeitura";
			this.lbLeitura.Size = new System.Drawing.Size(92, 13);
			this.lbLeitura.TabIndex = 12;
			this.lbLeitura.Text = "Leitura do arquivo";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.sistemaToolStripMenuItem,
			this.jogosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(569, 24);
			this.menuStrip1.TabIndex = 14;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// sistemaToolStripMenuItem
			// 
			this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fecharToolStripMenuItem});
			this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
			this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.sistemaToolStripMenuItem.Text = "Sistema";
			// 
			// fecharToolStripMenuItem
			// 
			this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
			this.fecharToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.fecharToolStripMenuItem.Text = "Fechar";
			// 
			// jogosToolStripMenuItem
			// 
			this.jogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mnuRegistrarSorteios,
			this.visualizarJogosGeradosToolStripMenuItem});
			this.jogosToolStripMenuItem.Name = "jogosToolStripMenuItem";
			this.jogosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.jogosToolStripMenuItem.Text = "Jogos";
			// 
			// mnuRegistrarSorteios
			// 
			this.mnuRegistrarSorteios.Name = "mnuRegistrarSorteios";
			this.mnuRegistrarSorteios.Size = new System.Drawing.Size(200, 22);
			this.mnuRegistrarSorteios.Text = "Registrar sorteio";
			this.mnuRegistrarSorteios.Click += new System.EventHandler(this.MnuRegistrarSorteiosClick);
			// 
			// visualizarJogosGeradosToolStripMenuItem
			// 
			this.visualizarJogosGeradosToolStripMenuItem.Name = "visualizarJogosGeradosToolStripMenuItem";
			this.visualizarJogosGeradosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.visualizarJogosGeradosToolStripMenuItem.Text = "Visualizar jogos gerados";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(569, 591);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.pbLeituraArquivo);
			this.Controls.Add(this.tcOpcoes);
			this.Controls.Add(this.lbLeitura);
			this.Controls.Add(this.chkLimparArquivo);
			this.Controls.Add(this.lbTitulo);
			this.MainMenuStrip = this.menuStrip1;
			this.MaximumSize = new System.Drawing.Size(585, 629);
			this.MinimumSize = new System.Drawing.Size(585, 629);
			this.Name = "MainForm";
			this.Text = "Gerador de jogos LotoFácil";
			this.tcOpcoes.ResumeLayout(false);
			this.tpAnalise.ResumeLayout(false);
			this.tpAnalise.PerformLayout();
			this.tpGerador.ResumeLayout(false);
			this.tpGerador.PerformLayout();
			this.gbConfiguracoes.ResumeLayout(false);
			this.gbConfiguracoes.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.updNumBolas)).EndInit();
			this.ctxRegras.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.updPares)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.updImpares)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.updMaiorIntervalo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.updQuantidade)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.updMaiorSequencia)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown updNumBolas;
		private System.Windows.Forms.ToolStripMenuItem visualizarJogosGeradosToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem jogosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuRegistrarSorteios;
		private System.Windows.Forms.ListView lvRegras;
		private System.Windows.Forms.ColumnHeader colMaiorSequencia;
		private System.Windows.Forms.ColumnHeader colMaiorIntervalo;
		private System.Windows.Forms.ColumnHeader colPares;
		private System.Windows.Forms.ColumnHeader colImpares;
		private System.Windows.Forms.ContextMenuStrip ctxRegras;
		private System.Windows.Forms.ToolStripMenuItem excluirRegraToolStripMenuItem;
		private System.Windows.Forms.Button bAdicionarRegra;
		private System.Windows.Forms.RichTextBox rtJogos;
		private System.Windows.Forms.Label lbTotalReprovados;
		private System.Windows.Forms.Label lbCoincidencias;
		private System.Windows.Forms.Label lbJogoGerado;
		private System.Windows.Forms.Label lbEstiloParesImpares;
		private System.Windows.Forms.Label lbEstiloJogo;
		private System.Windows.Forms.Label lbTamanhoSequencia;
		private System.Windows.Forms.Label lbTamanhoIntervalo;
		private System.Windows.Forms.Label lbDistribuicaoParesImpares;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbJogosReprovados;
		private System.Windows.Forms.NumericUpDown updPares;
		private System.Windows.Forms.Label lbPares;
		private System.Windows.Forms.NumericUpDown updImpares;
		private System.Windows.Forms.Label lbImpares;
		private System.Windows.Forms.ProgressBar pbEstiloImparPar;
		private System.Windows.Forms.Label lbEstiloImparPar;
		private System.Windows.Forms.ProgressBar pbImparPar;
		private System.Windows.Forms.Label lbImparPar;
		private System.Windows.Forms.ProgressBar pbJogosValidos;
		private System.Windows.Forms.ProgressBar pbLeituraArquivo;
		private System.Windows.Forms.Label lbLeitura;
		private System.Windows.Forms.NumericUpDown updQuantidade;
		private System.Windows.Forms.Label lbJogosGerados;
		private System.Windows.Forms.Button btnGerarJogos;
		private System.Windows.Forms.GroupBox gbConfiguracoes;
		private System.Windows.Forms.NumericUpDown updMaiorIntervalo;
		private System.Windows.Forms.Label lbConfMaiorIntervalo;
		private System.Windows.Forms.NumericUpDown updMaiorSequencia;
		private System.Windows.Forms.Label lbConfMaiorSequencia;
		private System.Windows.Forms.TextBox txtResultados;
		private System.Windows.Forms.Label lbResultados;
		private System.Windows.Forms.ProgressBar pbSequenciasCompletas;
		private System.Windows.Forms.Label lbSequenciasCompletas;
		private System.Windows.Forms.ProgressBar pbMaiorIntervalo;
		private System.Windows.Forms.Label lbMaiorIntervalo;
		private System.Windows.Forms.ProgressBar pbSequencias;
		private System.Windows.Forms.Label lbSequencias;
		private System.Windows.Forms.ProgressBar pbMaiorSequencia;
		private System.Windows.Forms.Label lbMaiorSequencia;
		private System.Windows.Forms.CheckBox chkLimparArquivo;
		private System.Windows.Forms.Button btnAnalisar;
		private System.Windows.Forms.TabControl tcOpcoes;
		private System.Windows.Forms.TabPage tpAnalise;
		private System.Windows.Forms.TabPage tpGerador;
		private System.Windows.Forms.Label lbTitulo;
	}
}
