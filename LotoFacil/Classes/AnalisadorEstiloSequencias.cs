/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 23/10/2015
 * Time: 13:15
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
	public class AnalisadorEstiloSequencias: BaseAnalisador<string, int>
	{
		public AnalisadorEstiloSequencias()
		{
			this.Analise = new Dictionary<string, int>();
		}
		
		public override void Analisar(object arg){
			if (arg.GetType() != typeof(List<Jogo>)){
				throw new ArgumentException("O objeto informado deve ser do tipo lista de jogos.");
			}
			
			List<Jogo> jogos = (List<Jogo>) arg;
			foreach (Jogo jogo in jogos) {
				RaiseOnJogoAnalisado(this, new EventArgs());
				
				if (Analise.ContainsKey(jogo.EstiloSequencias)) {
					Analise[jogo.EstiloSequencias]++;
				} else {
					Analise.Add(jogo.EstiloSequencias, 1);
				}
			}
		}
	}
}
