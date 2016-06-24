/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 02/12/2015
 * Time: 17:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using LotoFacil.Classes;
using LotoFacil.Validadores;

namespace LotoFacil.Classes
{
	/// <summary>
	/// Description of JogoAprovadoArgs.
	/// </summary>
	public class JogoAprovadoArgs
	{
		public Jogo Jogo { get; set; }
		public ValidadorGenerico Validador { get; set; }
			
		public JogoAprovadoArgs(Jogo jogo, ValidadorGenerico validador)
		{
			this.Jogo = jogo;
			this.Validador = validador;
		}
	}
}
