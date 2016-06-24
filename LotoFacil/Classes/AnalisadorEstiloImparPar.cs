/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 29/10/2015
 * Time: 18:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace LotoFacil.Classes
{
	/// <summary>
	/// Description of AnalisadorImparPar.
	/// </summary>
	public class AnalisadorEstiloImparPar: BaseAnalisador<string, int>
	{
		public AnalisadorEstiloImparPar()
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
				
				if (Analise.ContainsKey(jogo.EstiloImparPar)) {
					Analise[jogo.EstiloImparPar]++;
				} else {
					Analise.Add(jogo.EstiloImparPar, 1);
				}
			}
		}
	}
}
