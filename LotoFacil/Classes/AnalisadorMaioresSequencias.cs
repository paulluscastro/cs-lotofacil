/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 08/10/2015
 * Time: 15:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;
using System.Collections.Generic;

namespace LotoFacil.Classes
{
	/// <summary>
	/// Description of AnalisadorEstiloSequencias.
	/// </summary>
	public class AnalisadorMaioresSequencias: BaseAnalisador<int, int>
	{
		public AnalisadorMaioresSequencias()
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
				
				if (Analise.ContainsKey(jogo.MaiorSequencia)) {
					Analise[jogo.MaiorSequencia]++;
				} else {
					Analise.Add(jogo.MaiorSequencia, 1);
				}
			}
		}
	}
}
