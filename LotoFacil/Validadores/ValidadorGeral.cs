/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 03/11/2015
 * Time: 19:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using System.Collections.Generic;

using LotoFacil.Enums;
using LotoFacil.Classes;

namespace LotoFacil.Validadores
{
	/// <summary>
	/// Description of ValidadorGeral.
	/// </summary>
	/// 
	public class ValidadorGeral: IValidador
	{
		public static readonly int FATOR_COINCIDENCIA = 13;
		
		public List<Jogo> JogosPassados { get; set; }
		public List<Jogo> BancoAnalise { get; set; }
			
		public ValidadorGeral()
		{
			BancoAnalise = new List<Jogo>();
			JogosPassados = new List<Jogo>();
		}
		
		public MotivoReprovacao Validar(Jogo jogo){
			// Verifica se o jogo já existe
			var jogoExiste = from j in BancoAnalise
				where j.ToString() == jogo.ToString()
				select j;
			
			if (jogoExiste.Count() > 0)
				return MotivoReprovacao.EXISTENTE;
		
			// Verifica se o estilo de sequências já foi sorteado
			var estiloExiste = from j in BancoAnalise
				where j.EstiloSequencias == jogo.EstiloSequencias
				select j;
			
			if (estiloExiste.Count() > 0)
				return MotivoReprovacao.ESTILO;
			
			// Verifica se o estilo ímpar par já foi sorteado
			var estiloImparParExiste = from j in BancoAnalise
				where j.EstiloImparPar == jogo.EstiloImparPar
				select j;
			
			if (estiloImparParExiste.Count() > 0)
				return MotivoReprovacao.ESTILO_IMPAR_PAR;

			// Verifica número máximo de coincidências
			var coincidencias = from j in BancoAnalise
				where j.SequenciaCoincidente(jogo.ToString()) > FATOR_COINCIDENCIA
				select j;
			
			if (coincidencias.Count() > 0)
				return MotivoReprovacao.COINCIDENCIA;
			
			return MotivoReprovacao.NENHUM;
		}
	}
}
