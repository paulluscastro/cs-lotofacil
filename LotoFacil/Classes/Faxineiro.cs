/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 02/10/2015
 * Time: 16:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LotoFacil.Classes
{
	/// <summary>
	/// Description of Faxineiro.
	/// </summary>
	public class Faxineiro
	{
		public event EventHandler OnArquivoLido;
		public event EventHandler OnLinhaLida;
		public int LinhasArquivo { get; set; }

		public Faxineiro()
		{
		}
		
		public void LimparArquivo(){
			LimparArquivo(Directory.GetCurrentDirectory() + "\\base.txt");
		}
		
		public void LimparArquivo(String caminho){
			if (!File.Exists(caminho)) {
				throw new FileNotFoundException("Arquivo não encontrado");
			}
			
			string[] linhas = File.ReadAllLines(caminho);
			LinhasArquivo = linhas.Length;
			if (OnArquivoLido != null){
				OnArquivoLido(this, new EventArgs());
			}
			
			List<string> resultado = new List<string>();
			
			foreach (String linha in linhas) {
				if (OnLinhaLida != null){
					OnLinhaLida(this, new EventArgs());
				}
				if (linha.Trim() == "") {
					continue;
				} else {
					resultado.Add(linha.Trim());
				}
			}
			
			File.WriteAllLines(caminho, resultado.ToArray());
		}
		
	}
}
