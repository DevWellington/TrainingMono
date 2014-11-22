using System;

namespace Exemplo1
{
	public class Carro
	{
		public int Portas { get; set; }
		//public int Ano  { get; set; }
		public int? Ano  { get; set; }
		public string Modelo  { get; set; }

		public int Autonomia
		{
			get{ 
				return CalcularAutonomia();
			}
		}

		private int CalcularAutonomia()
		{
			return this.Portas * 42;
		}

		public Carro (int portas)
		{
			this.Portas = portas;
		}


	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Carro meuCarro = new Carro (4);
			//meuCarro.Ano = 2014;
			meuCarro.Ano = null;
			meuCarro.Modelo = "Modelo";

			Console.WriteLine (meuCarro.Portas);
			Console.WriteLine (meuCarro.Ano);
			Console.WriteLine (meuCarro.Modelo);

			Console.WriteLine (meuCarro.Autonomia);

			exemploTryCatch ();

			Console.ReadKey ();
		}

		public static void exemploTryCatch()
		{
			try {
				var div = Console.ReadLine();
				int x = 10/Convert.ToInt32(div);

			} catch (DivideByZeroException ex) {
				Console.WriteLine ("DIVISAO POR ZERO");
			}
		}
	}
}
