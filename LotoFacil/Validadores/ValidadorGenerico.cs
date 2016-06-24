/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 03/11/2015
 * Time: 19:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using LotoFacil.Enums;
using LotoFacil.Classes;

namespace LotoFacil.Validadores
{
	/// <summary>
	/// Description of ValidadorGenerico.
	/// </summary>
	/// 
	public class ValidadorGenerico: IValidador
	{
		public int NumerosPares { get; set; }
		public int MaiorIntervalo { get; set; }
		public int MaiorSequencia { get; set; }
		
		public ValidadorGenerico()
		{
		}
		
		public MotivoReprovacao Validar(Jogo jogo) {
			// Verifica regra do maior intervalo
			if (jogo.MaiorIntervalo > MaiorIntervalo)
				return MotivoReprovacao.INTERVALO;
			
			// Verifica regra da maior sequência
			if (jogo.MaiorSequencia > MaiorSequencia)
				return MotivoReprovacao.SEQUENCIA;
			
			// Verifica regra de números pares
			if (jogo.Pares < NumerosPares)
				return MotivoReprovacao.PARES_IMPARES;
			
			// Verifica regra de números ímpares
			if (jogo.Impares < (15 - NumerosPares))
				return MotivoReprovacao.PARES_IMPARES;

			return MotivoReprovacao.NENHUM;
		}
		
		public override string ToString() {
			return "SEQ" + MaiorSequencia.ToString("00") + "INT" + MaiorIntervalo.ToString("00") + "PAR" + NumerosPares.ToString("00") + "IMPAR" + (15 - NumerosPares).ToString("00");
		}
	}
}
