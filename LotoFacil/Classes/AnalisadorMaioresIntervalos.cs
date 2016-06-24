/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 08/10/2015
 * Time: 15:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace LotoFacil.Classes
{
	/// <summary>
	/// Description of AnalisadorEstiloSequencias.
	/// </summary>
	public class AnalisadorMaioresIntervalos: BaseAnalisador<int, int>
	{
		public AnalisadorMaioresIntervalos()
		{
			this.Analise = new Dictionary<int, int>();
		}
		
		public override void Analisar(object arg){
			if (arg.GetType() != typeof(List<Jogo>)){
				throw new ArgumentException("O objeto informado deve ser do tipo lista de jogos.");
			}
			
			List<Jogo> jogos = (List<Jogo>) arg;
			foreach (Jogo jogo in jogos) {
				RaiseOnJogoAnalisado(this, new EventArgs());
			
				if (Analise.ContainsKey(jogo.MaiorIntervalo)) {
					Analise[jogo.MaiorIntervalo]++;
				} else {
					Analise.Add(jogo.MaiorIntervalo, 1);
				}
			}
		}
	}
}
