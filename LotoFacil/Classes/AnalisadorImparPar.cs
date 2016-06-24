/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 29/10/2015
 * Time: 18:20
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
	public class AnalisadorImparPar: BaseAnalisador<string, int>
	{
		public AnalisadorImparPar()
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
				
				if (Analise.ContainsKey(jogo.ImparPar)) {
					Analise[jogo.ImparPar]++;
				} else {
					Analise.Add(jogo.ImparPar, 1);
				}
			}
		}
	}
}
