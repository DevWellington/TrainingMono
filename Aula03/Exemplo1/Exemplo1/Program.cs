using System;

namespace Exemplo1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int idade = 18;

			//if (idade > 18)
			if (idade >= 18) {
				Console.WriteLine ("Autorizado");
				Console.WriteLine ("Voce tem " + idade + " anos");

			} else if (idade > 15 && idade < 18) {
				Console.WriteLine ("Somente com os pais.");
				Console.WriteLine ("Menor de 18 anos");

			} else {
				Console.WriteLine ("Nao autorizado");
				Console.WriteLine ("Menor de idade");

			}

			diaSemanaTest ();
			diaSemanaFimSemanaEDiaSemana ();

			utilizandoFor ();
			utilizandoWhile ();
			utilizandoDoWhile ();

			contar (50);
			contarColorido (10, true);

			int resultadoSoma = somar (10, true);
			Console.WriteLine (resultadoSoma);


			Console.ReadKey();
		}

		enum DiaSemana
		{
			Seg,
			Ter,
			Qua,
			Qui,
			Sex,
			Sab,
			Dom

		}

		public static void diaSemanaTest()
		{
			var dia = DiaSemana.Sab;

			switch (dia) {

				case DiaSemana.Dom:
					Console.WriteLine ("DOMINGO");
					break;
				case DiaSemana.Sab:
					Console.WriteLine ("SABADO");
					break;
				default:
					Console.WriteLine ("OUTRO DIA");
					break;
			}

		}

		public static void diaSemanaFimSemanaEDiaSemana()
		{
			var dia = DiaSemana.Sab;

			switch (dia) {

				case DiaSemana.Dom:
				case DiaSemana.Sab:
					Console.WriteLine ("FIM DE SEMANA");
					break;
				case DiaSemana.Seg:
				case DiaSemana.Ter:
				case DiaSemana.Qua:
				case DiaSemana.Qui:
				case DiaSemana.Sex:
					Console.WriteLine ("DIA UTIL");
					break;
				default:
					Console.WriteLine ("OUTRO DIA");
					break;
			}
		}

		public static void utilizandoFor()
		{
			for (int i = 0; i < 10; i++) {
				Console.WriteLine (i);
			}
		}

		public static void utilizandoWhile()
		{
			int i = 0;
			while (i < 10) {
				Console.WriteLine (i);
				i++;
				//i = i + 1;
			}

		}

		public static void utilizandoDoWhile()
		{
			int i = 0;

			do {
				Console.WriteLine (i);
				i++;
			} while (i < 10);

		}

		public static void contar(int ate)
		{
			for (int i = 0; i < ate; i++) {
				Console.WriteLine (i);
			}
		}

		public static void contarColorido(int ate, bool colorido=false)
		{
			for (int i = 0; i < ate; i++) {
				if (colorido)
					Console.ForegroundColor = ConsoleColor.Blue;

				Console.WriteLine (i);
			}
		}

		
		public static int somar(int ate, bool colorido=false)
		{
			int soma = 0;
			for (int i = 0; i < ate; i++) {
				soma += i;
			}

			if (colorido)
				Console.ForegroundColor = ConsoleColor.Red;

			return soma;
		}

	}
}
