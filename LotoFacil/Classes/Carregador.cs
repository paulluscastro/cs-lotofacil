/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 02/10/2015
 * Time: 16:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;

namespace LotoFacil.Classes
{
	/// <summary>
	/// Description of Carregador.
	/// </summary>
	public class Carregador
	{
		public event EventHandler OnArquivoLido;
		public event EventHandler OnLinhaLida;
		public int LinhasArquivo { get; set; }

		public Carregador()
		{
		}
		
		public List<Jogo> LerArquivo(string caminho) {
			if (!File.Exists(caminho)) {
				throw new FileNotFoundException("Arquivo não encontrado");
			}
			
			string[] linhas = File.ReadAllLines(caminho);
			LinhasArquivo = linhas.Length;
			if (OnArquivoLido != null) {
				OnArquivoLido(this, new EventArgs());
			}
			List<Jogo> resultado = new List<Jogo>();
			
			foreach (String linha in linhas) {
				if (OnLinhaLida != null) {
					OnLinhaLida(this, new EventArgs());
				}
				
				// Ignorar linhas em branco
				if (linha.Trim() == "")
					continue;
				
				Jogo jogo = new Jogo(linha);
				resultado.Add(jogo);
			}
			return resultado;
		}
	}
}
