/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 02/10/2015
 * Time: 16:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LotoFacil.Classes
{
	/// <summary>
	/// Description of AnalisadorSequencia.
	/// </summary>
	public class AnalisadorJogo
	{
		public int MaiorSequencia{ get; set;}
		public string EstiloSequencias { get; set; }
		public int Impares { get; set; }
		public int Pares { get; set; }
		public string ImparPar { get; set; }
		public string EstiloImparPar { get; set; }
		public int MaiorIntervalo{ get; set;}
		public string EstiloSequenciasCompleto { get; set; }
		
		public AnalisadorJogo()
		{
		}
		
		public void Analisar(object arg){
			if (arg.GetType() != typeof(Jogo)){
				throw new ArgumentException("O objeto informado deve ser do tipo Jogo.");
			}

			int anterior = -1;
			int sequenciaAtual = 0;
			
			// Zerando atributos
			MaiorSequencia = 0;
			EstiloSequencias = "";
			MaiorIntervalo = 0;
			EstiloSequenciasCompleto = "";
			ImparPar = "";
			
			Pares = 0;
			Impares = 0;
			
			Jogo jogo = (Jogo) arg;
			foreach (int bola in jogo.Bolas) {
				if (bola % 2 == 0) Pares++; else Impares++;
				
				EstiloImparPar += bola % 2 == 0 ? "P" : "I";
				
				if (anterior == -1) {
					sequenciaAtual = 1;
					MaiorSequencia = 1;
					anterior = bola;
					continue;
				}
				
				if (bola == (anterior + 1)) {
					sequenciaAtual++;
					MaiorSequencia += sequenciaAtual > MaiorSequencia ? 1 : 0;
				} else {
					EstiloSequencias += sequenciaAtual + "B ";
					EstiloSequenciasCompleto += sequenciaAtual + "B " + (bola - anterior) + "I ";
					sequenciaAtual = 1;
				}
				
				MaiorIntervalo = (bola - anterior > MaiorIntervalo) ? bola - anterior : MaiorIntervalo;
				
				anterior = bola;
			}
			ImparPar = Pares + "P" + Impares + "I";
			EstiloSequencias += sequenciaAtual + "B";
			EstiloSequenciasCompleto += sequenciaAtual + "B";
		}
	}
}
