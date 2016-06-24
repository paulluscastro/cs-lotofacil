/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 03/11/2015
 * Time: 18:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Data;
using System.Text;
using System.Collections.Generic;

using LotoFacil.Enums;
using LotoFacil.Classes;
using LotoFacil.Validadores;

namespace LotoFacil.BancoDados
{
	/// <summary>
	/// Description of BancoDados.
	/// </summary>
	public class BancoDados
	{
		public static readonly string CAMINHO = Directory.GetCurrentDirectory();
		public static readonly string CAMINHO_COMPLETO = Directory.GetCurrentDirectory() + "\\base.xml";
		private DataSet ds = new DataSet("LOTOFACIL");
		
		public Carregador Carregador { get; set; }
		public Faxineiro Faxineiro { get; set; }
		public DataSet Ds
		{ 
			get {
				return ds;
			}
		}
		
		public BancoDados()
		{
			// Tenta carregar o banco de dados do arquivo local
			if (File.Exists(CAMINHO_COMPLETO)) {
				ds.ReadXml(CAMINHO_COMPLETO, XmlReadMode.ReadSchema);
			} else {
				// Se o arquivo não existir, criamos o banco tabela por tabela
				
				// ****************************** TABELA DE JOGOS ANTIGOS ******************************
				DataTable tbAntigos = new DataTable("ANTIGOS");
				
				// Número do concurso
				tbAntigos.Columns.Add(new DataColumn("CONCURSO", typeof(int)));
				// Data do concurso
				tbAntigos.Columns.Add(new DataColumn("DATA", typeof(DateTime)));
				// Bola 01
				tbAntigos.Columns.Add(new DataColumn("BOLA01", typeof(int)));
				// Bola 02
				tbAntigos.Columns.Add(new DataColumn("BOLA02", typeof(int)));
				// Bola 03
				tbAntigos.Columns.Add(new DataColumn("BOLA03", typeof(int)));
				// Bola 04
				tbAntigos.Columns.Add(new DataColumn("BOLA04", typeof(int)));
				// Bola 05
				tbAntigos.Columns.Add(new DataColumn("BOLA05", typeof(int)));
				// Bola 06
				tbAntigos.Columns.Add(new DataColumn("BOLA06", typeof(int)));
				// Bola 07
				tbAntigos.Columns.Add(new DataColumn("BOLA07", typeof(int)));
				// Bola 08
				tbAntigos.Columns.Add(new DataColumn("BOLA08", typeof(int)));
				// Bola 09
				tbAntigos.Columns.Add(new DataColumn("BOLA09", typeof(int)));
				// Bola 10
				tbAntigos.Columns.Add(new DataColumn("BOLA10", typeof(int)));
				// Bola 11
				tbAntigos.Columns.Add(new DataColumn("BOLA11", typeof(int)));
				// Bola 12
				tbAntigos.Columns.Add(new DataColumn("BOLA12", typeof(int)));
				// Bola 13
				tbAntigos.Columns.Add(new DataColumn("BOLA13", typeof(int)));
				// Bola 14
				tbAntigos.Columns.Add(new DataColumn("BOLA14", typeof(int)));
				// Bola 15
				tbAntigos.Columns.Add(new DataColumn("BOLA15", typeof(int)));
				
				// Chave primária
				tbAntigos.PrimaryKey = new DataColumn[]{tbAntigos.Columns["CONCURSO"]};
				ds.Tables.Add(tbAntigos);
				
				// ****************************** TABELA DE JOGOS GERADOS ******************************
				DataTable tbGerados = new DataTable("GERADOS");
				
				// UUID
				tbGerados.Columns.Add(new DataColumn("UUID", typeof(Guid)));
				// Data/Hora em que o jogo foi gerado
				tbGerados.Columns.Add(new DataColumn("DATA_HORA", typeof(DateTime)));
				// Bola 01
				tbGerados.Columns.Add(new DataColumn("BOLA01", typeof(int)));
				// Bola 02
				tbGerados.Columns.Add(new DataColumn("BOLA02", typeof(int)));
				// Bola 03
				tbGerados.Columns.Add(new DataColumn("BOLA03", typeof(int)));
				// Bola 04
				tbGerados.Columns.Add(new DataColumn("BOLA04", typeof(int)));
				// Bola 05
				tbGerados.Columns.Add(new DataColumn("BOLA05", typeof(int)));
				// Bola 06
				tbGerados.Columns.Add(new DataColumn("BOLA06", typeof(int)));
				// Bola 07
				tbGerados.Columns.Add(new DataColumn("BOLA07", typeof(int)));
				// Bola 08
				tbGerados.Columns.Add(new DataColumn("BOLA08", typeof(int)));
				// Bola 09
				tbGerados.Columns.Add(new DataColumn("BOLA09", typeof(int)));
				// Bola 10
				tbGerados.Columns.Add(new DataColumn("BOLA10", typeof(int)));
				// Bola 11
				tbGerados.Columns.Add(new DataColumn("BOLA11", typeof(int)));
				// Bola 12
				tbGerados.Columns.Add(new DataColumn("BOLA12", typeof(int)));
				// Bola 13
				tbGerados.Columns.Add(new DataColumn("BOLA13", typeof(int)));
				// Bola 14
				tbGerados.Columns.Add(new DataColumn("BOLA14", typeof(int)));
				// Bola 15
				tbGerados.Columns.Add(new DataColumn("BOLA15", typeof(int)));
				// Bola 16
				tbGerados.Columns.Add(new DataColumn("BOLA16", typeof(int)));
				// Bola 17
				tbGerados.Columns.Add(new DataColumn("BOLA17", typeof(int)));
				// Bola 18
				tbGerados.Columns.Add(new DataColumn("BOLA18", typeof(int)));
				// Regra de validação em que o jogo se encaixou 
				tbGerados.Columns.Add(new DataColumn("REGRA", typeof(string)));
				// Indica se foi apostado ou não 
				tbGerados.Columns.Add(new DataColumn("APOSTADO", typeof(bool)));
				// Indica se foi apostado ou não 
				tbGerados.Columns.Add(new DataColumn("TIPO", typeof(TipoAposta)));
				
				// Chave primária
				tbGerados.PrimaryKey = new DataColumn[]{tbGerados.Columns["UUID"]};
				ds.Tables.Add(tbGerados);
				
				// ****************************** TABELA DE JOGOS REPROVADOS ******************************
				DataTable tbReprovados = new DataTable("REPROVADOS");
				
				// UUID
				tbReprovados.Columns.Add(new DataColumn("UUID", typeof(Guid)));
				// Data/Hora em que o jogo foi gerado
				tbReprovados.Columns.Add(new DataColumn("DATA_HORA", typeof(DateTime)));
				// Bola 01
				tbReprovados.Columns.Add(new DataColumn("BOLA01", typeof(int)));
				// Bola 02
				tbReprovados.Columns.Add(new DataColumn("BOLA02", typeof(int)));
				// Bola 03
				tbReprovados.Columns.Add(new DataColumn("BOLA03", typeof(int)));
				// Bola 04
				tbReprovados.Columns.Add(new DataColumn("BOLA04", typeof(int)));
				// Bola 05
				tbReprovados.Columns.Add(new DataColumn("BOLA05", typeof(int)));
				// Bola 06
				tbReprovados.Columns.Add(new DataColumn("BOLA06", typeof(int)));
				// Bola 07
				tbReprovados.Columns.Add(new DataColumn("BOLA07", typeof(int)));
				// Bola 08
				tbReprovados.Columns.Add(new DataColumn("BOLA08", typeof(int)));
				// Bola 09
				tbReprovados.Columns.Add(new DataColumn("BOLA09", typeof(int)));
				// Bola 10
				tbReprovados.Columns.Add(new DataColumn("BOLA10", typeof(int)));
				// Bola 11
				tbReprovados.Columns.Add(new DataColumn("BOLA11", typeof(int)));
				// Bola 12
				tbReprovados.Columns.Add(new DataColumn("BOLA12", typeof(int)));
				// Bola 13
				tbReprovados.Columns.Add(new DataColumn("BOLA13", typeof(int)));
				// Bola 14
				tbReprovados.Columns.Add(new DataColumn("BOLA14", typeof(int)));
				// Bola 15
				tbReprovados.Columns.Add(new DataColumn("BOLA15", typeof(int)));
				// Bola 16
				tbReprovados.Columns.Add(new DataColumn("BOLA16", typeof(int)));
				// Bola 17
				tbReprovados.Columns.Add(new DataColumn("BOLA17", typeof(int)));
				// Bola 18
				tbReprovados.Columns.Add(new DataColumn("BOLA18", typeof(int)));
				// Regra de validação em que o jogo não se encaixou 
				tbReprovados.Columns.Add(new DataColumn("REGRAS", typeof(string)));
				// Indica se foi apostado ou não 
				tbReprovados.Columns.Add(new DataColumn("MOTIVO", typeof(MotivoReprovacao)));
				
				// Chave primária
				tbReprovados.PrimaryKey = new DataColumn[]{tbReprovados.Columns["UUID"]};
				ds.Tables.Add(tbReprovados);
			}
		}
		
		public void CarregarArquivo() {
			CarregarArquivo(false);
		}
		
		public void CarregarArquivo(bool limpar) {
			if (Carregador == null)
				throw new Exception("O carregador não foi associado ao gerenciador de banco de dados.");
			if ((limpar) && (Faxineiro == null))
				throw new Exception("O faxineiro não foi associado ao gerenciador de banco de dados.");
			
			if (limpar) {
				Faxineiro.LimparArquivo(CAMINHO + "\\base.txt");
			}
			
			List<Jogo> jogos = Carregador.LerArquivo(CAMINHO + "\\base.txt");
			foreach (Jogo jogo in jogos) {
				AdicionarJogoPassado(jogo);
			}
			
			Salvar();
		}
		
		public List<Jogo> ObterJogosPassados(){
			DataTable passados = ds.Tables["ANTIGOS"];
			
			if (passados.Rows.Count == 0) {
				CarregarArquivo();
			}
			
			List<Jogo> retorno = new List<Jogo>(passados.Rows.Count);
			
			foreach (DataRow linha in passados.Rows) {
				Jogo jogo = new Jogo();
				jogo.Data = (DateTime)linha["DATA"];
				jogo.Bola01 = (int)linha["BOLA01"];
				jogo.Bola02 = (int)linha["BOLA02"];
				jogo.Bola03 = (int)linha["BOLA03"];
				jogo.Bola04 = (int)linha["BOLA04"];
				jogo.Bola05 = (int)linha["BOLA05"];
				jogo.Bola06 = (int)linha["BOLA06"];
				jogo.Bola07 = (int)linha["BOLA07"];
				jogo.Bola08 = (int)linha["BOLA08"];
				jogo.Bola09 = (int)linha["BOLA09"];
				jogo.Bola10 = (int)linha["BOLA10"];
				jogo.Bola11 = (int)linha["BOLA11"];
				jogo.Bola12 = (int)linha["BOLA12"];
				jogo.Bola13 = (int)linha["BOLA13"];
				jogo.Bola14 = (int)linha["BOLA14"];
				jogo.Bola15 = (int)linha["BOLA15"];

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
				jogo.AnalisarJogo();
				
				retorno.Add(jogo);
			}
			
			return retorno;
		}
		public List<Jogo> ObterJogosGerados(){
			return ObterJogosGerados(false);
		}
		
		public List<Jogo> ObterJogosGerados(bool somenteNaoApostados){
			DataTable passados = ds.Tables["GERADOS"];
			List<Jogo> retorno = new List<Jogo>();
			
			foreach (DataRow linha in passados.Rows) {
				if ((somenteNaoApostados) && ((bool)linha["APOSTADO"]))
					continue;
				
				Jogo jogo = new Jogo();
				jogo.Uuid = (Guid)linha["UUID"];
				jogo.Data = (DateTime)linha["DATA_HORA"];
				jogo.Bola01 = (int)linha["BOLA01"];
				jogo.Bola02 = (int)linha["BOLA02"];
				jogo.Bola03 = (int)linha["BOLA03"];
				jogo.Bola04 = (int)linha["BOLA04"];
				jogo.Bola05 = (int)linha["BOLA05"];
				jogo.Bola06 = (int)linha["BOLA06"];
				jogo.Bola07 = (int)linha["BOLA07"];
				jogo.Bola08 = (int)linha["BOLA08"];
				jogo.Bola09 = (int)linha["BOLA09"];
				jogo.Bola10 = (int)linha["BOLA10"];
				jogo.Bola11 = (int)linha["BOLA11"];
				jogo.Bola12 = (int)linha["BOLA12"];
				jogo.Bola13 = (int)linha["BOLA13"];
				jogo.Bola14 = (int)linha["BOLA14"];
				jogo.Bola15 = (int)linha["BOLA15"];
				jogo.Bola16 = (int)linha["BOLA16"];
				jogo.Bola17 = (int)linha["BOLA17"];
				jogo.Bola18 = (int)linha["BOLA18"];

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
				jogo.Bolas.Add(jogo.Bola16);
				jogo.Bolas.Add(jogo.Bola17);
				jogo.Bolas.Add(jogo.Bola18);
				jogo.AnalisarJogo();
				
				retorno.Add(jogo);
			}
			
			return retorno;
		}
		
		public List<Jogo> ObterJogosReprovados(){
			DataTable passados = ds.Tables["REPROVADOS"];
			List<Jogo> retorno = new List<Jogo>();
			
			foreach (DataRow linha in passados.Rows) {
				Jogo jogo = new Jogo();
				jogo.Uuid = (Guid)linha["UUID"];
				jogo.Data = (DateTime)linha["DATA_HORA"];
				jogo.Bola01 = (int)linha["BOLA01"];
				jogo.Bola02 = (int)linha["BOLA02"];
				jogo.Bola03 = (int)linha["BOLA03"];
				jogo.Bola04 = (int)linha["BOLA04"];
				jogo.Bola05 = (int)linha["BOLA05"];
				jogo.Bola06 = (int)linha["BOLA06"];
				jogo.Bola07 = (int)linha["BOLA07"];
				jogo.Bola08 = (int)linha["BOLA08"];
				jogo.Bola09 = (int)linha["BOLA09"];
				jogo.Bola10 = (int)linha["BOLA10"];
				jogo.Bola11 = (int)linha["BOLA11"];
				jogo.Bola12 = (int)linha["BOLA12"];
				jogo.Bola13 = (int)linha["BOLA13"];
				jogo.Bola14 = (int)linha["BOLA14"];
				jogo.Bola15 = (int)linha["BOLA15"];
				jogo.Bola16 = (int)linha["BOLA16"];
				jogo.Bola17 = (int)linha["BOLA17"];
				jogo.Bola18 = (int)linha["BOLA18"];

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
				jogo.Bolas.Add(jogo.Bola16);
				jogo.Bolas.Add(jogo.Bola17);
				jogo.Bolas.Add(jogo.Bola18);
				jogo.AnalisarJogo();
				
				retorno.Add(jogo);
			}
			
			return retorno;
		}		
		public void AdicionarJogoPassado(Jogo jogo){
			DataTable passados = ds.Tables["ANTIGOS"];
			
			DataRow linha = passados.NewRow();
			linha["CONCURSO"] = jogo.Numero;
			linha["DATA"] = jogo.Data;
			linha["BOLA01"] = jogo.Bola01;
			linha["BOLA02"] = jogo.Bola02;
			linha["BOLA03"] = jogo.Bola03;
			linha["BOLA04"] = jogo.Bola04;
			linha["BOLA05"] = jogo.Bola05;
			linha["BOLA06"] = jogo.Bola06;
			linha["BOLA07"] = jogo.Bola07;
			linha["BOLA08"] = jogo.Bola08;
			linha["BOLA09"] = jogo.Bola09;
			linha["BOLA10"] = jogo.Bola10;
			linha["BOLA11"] = jogo.Bola11;
			linha["BOLA12"] = jogo.Bola12;
			linha["BOLA13"] = jogo.Bola13;
			linha["BOLA14"] = jogo.Bola14;
			linha["BOLA15"] = jogo.Bola15;
			
			passados.Rows.Add(linha);
		}
		
		public void AdicionarJogoGerado(Jogo jogo, ValidadorGenerico validador){
			DataTable gerados = ds.Tables["GERADOS"];
			
			DataRow linha = gerados.NewRow();
			linha["UUID"] = Guid.NewGuid();
			linha["DATA_HORA"] = DateTime.Now;
			linha["BOLA01"] = jogo.Bola01;
			linha["BOLA02"] = jogo.Bola02;
			linha["BOLA03"] = jogo.Bola03;
			linha["BOLA04"] = jogo.Bola04;
			linha["BOLA05"] = jogo.Bola05;
			linha["BOLA06"] = jogo.Bola06;
			linha["BOLA07"] = jogo.Bola07;
			linha["BOLA08"] = jogo.Bola08;
			linha["BOLA09"] = jogo.Bola09;
			linha["BOLA10"] = jogo.Bola10;
			linha["BOLA11"] = jogo.Bola11;
			linha["BOLA12"] = jogo.Bola12;
			linha["BOLA13"] = jogo.Bola13;
			linha["BOLA14"] = jogo.Bola14;
			linha["BOLA15"] = jogo.Bola15;
			linha["BOLA16"] = jogo.Bola16;
			linha["BOLA17"] = jogo.Bola17;
			linha["BOLA18"] = jogo.Bola18;
			linha["REGRA"] = validador.ToString();
			linha["TIPO"] = TipoAposta.NENHUM;
			linha["APOSTADO"] = false;
			gerados.Rows.Add(linha);
			
			jogo.AnalisarJogo();
			
		}
		
		public void AdicionarJogoReprovado(Jogo jogo, MotivoReprovacao motivo, List<ValidadorGenerico> validadores){
			DataTable gerados = ds.Tables["REPROVADOS"];
			
			DataRow linha = gerados.NewRow();
			linha["UUID"] = Guid.NewGuid();
			linha["DATA_HORA"] = DateTime.Now;
			linha["BOLA01"] = jogo.Bola01;
			linha["BOLA02"] = jogo.Bola02;
			linha["BOLA03"] = jogo.Bola03;
			linha["BOLA04"] = jogo.Bola04;
			linha["BOLA05"] = jogo.Bola05;
			linha["BOLA06"] = jogo.Bola06;
			linha["BOLA07"] = jogo.Bola07;
			linha["BOLA08"] = jogo.Bola08;
			linha["BOLA09"] = jogo.Bola09;
			linha["BOLA10"] = jogo.Bola10;
			linha["BOLA11"] = jogo.Bola11;
			linha["BOLA12"] = jogo.Bola12;
			linha["BOLA13"] = jogo.Bola13;
			linha["BOLA14"] = jogo.Bola14;
			linha["BOLA15"] = jogo.Bola15;
			linha["BOLA16"] = jogo.Bola16;
			linha["BOLA17"] = jogo.Bola17;
			linha["BOLA18"] = jogo.Bola18;
			linha["MOTIVO"] = motivo;
			
			StringBuilder sb = new StringBuilder();
			foreach (ValidadorGenerico validator in validadores) {
				sb.Append(validator.ToString()).Append(System.Environment.NewLine);
			}
			
			linha["REGRAS"] = sb.ToString();
			gerados.Rows.Add(linha);
			
			jogo.AnalisarJogo();
			
		}
		
		public void Salvar() {
			ds.WriteXml(CAMINHO_COMPLETO, XmlWriteMode.WriteSchema);
		}
	}
}
