/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 02/12/2015
 * Time: 17:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using LotoFacil.Enums;

namespace LotoFacil.Classes
{
	/// <summary>
	/// Description of ReprovacaoArgs.
	/// </summary>
	public class JogoReprovadoArgs
	{
		public MotivoReprovacao MotivoReprovacao{ get; set;}
		
		public JogoReprovadoArgs(MotivoReprovacao motivoReprovacao)
		{
			this.MotivoReprovacao = motivoReprovacao;
		}
	}
}
