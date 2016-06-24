/*
 * Created by SharpDevelop.
 * User: paullus
 * Date: 20/10/2015
 * Time: 19:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace LotoFacil.Classes
{
	public delegate void ExecutarJogoAnalisado();
	
	/// <summary>
	/// Description of BaseAnalisador.
	/// </summary>
	public abstract class BaseAnalisador<K, V>
	{
		public event EventHandler OnJogoAnalisado;
		public string EstiloSequencias { get; set; }
		public IDictionary<K, V> Analise { get; set; }
		
		public abstract void Analisar(object arg);
		
		protected void RaiseOnJogoAnalisado(object sender, EventArgs args) {
			if (OnJogoAnalisado != null) {
				OnJogoAnalisado(sender, args);
			}
		}
	}
}
