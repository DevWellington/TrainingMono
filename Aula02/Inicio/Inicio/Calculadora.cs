using System;

namespace Inicio
{

	/// <summary>
	/// Calculadora.
	/// </summary>
	public class Calculadora
	{
		//int numero1;
		//int numero2;

		public int numero1;
		public int numero2;

		/// <summary>
		/// Initializes a new instance of the <see cref="Inicio.Calculadora"/> class.
		/// </summary>
		public Calculadora ()
		{
			Console.WriteLine ("Criada calculadora");
		}

		/// <summary>
		/// Somar this instance.
		/// </summary>
		public void somar()
		{
			Console.WriteLine ("Vou somar");

			// Migrado

			//int numero1 = 0;
			//int numero2 = 5000;

			//numero1 = 0;
			//numero2 = 5000;

			int total = numero1 + numero2;

			Console.WriteLine ("Resultado da Soma: " + total);
		}

		private void somar2()
		{
			Console.WriteLine ("Vou somar 2!");

			numero1 = 60;
			numero2 = 550;
		}

		public void SomarComParametros(int a, int b)
		{
			int total = a + b;
			Console.WriteLine ("Valor da soma com parametros: " + total);
		}

	}
}

