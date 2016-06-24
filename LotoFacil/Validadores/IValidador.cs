/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 03/11/2015
 * Time: 19:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using LotoFacil.Enums;
using LotoFacil.Classes;

namespace LotoFacil.Validadores
{
	/// <summary>
	/// Description of Interface1.
	/// </summary>
	public interface IValidador
	{
		MotivoReprovacao Validar(Jogo jogo);
	}
}
