using System;
/// <summary>
/// Programa aula02. Este é o primeiro exemplo da Aula 02;
/// </summary>
namespace Inicio
{
	/// <summary>
	/// Classe principal do programa
	/// </summary>
	class ProgramaAula02
	{
		long a_EscopoClasse = 5000;

		/// <summary>
		/// Metodo Main. Que vai ser executado no momento sempre primeiro
		/// ...
		/// </summary>
		/// <param name="args">Tudo que vem como argumento da Linha de Comando.</param>
		public static void Main (string[] args)
		{
			//Vou escrever alguma coisa na linha de comando
			Console.WriteLine ("Hello World!");

			Calculadora calc = new Calculadora();
			calc.numero1 = 20;
			calc.numero2 = 30;

			calc.somar();

			calc.SomarComParametros(1, 2);

			/*
			 * Comentarios no meio do código
			 * asd
			 * d
			 * fasd
			 * fas
			 */

			Console.WriteLine ("\n\n");
			Console.WriteLine ("Declaracao de Variáveis");

			// Declaracao de Variáveis
			int i;

			i = 10;
			i = 20;

			long l = 5000;

			string text = "Ola Mundo !";

			Console.WriteLine ("int i: " + i);
			Console.WriteLine ("long l: " + l);
			Console.WriteLine ("string text: " + text);

			// Uso de variaveis em escopos
			if (l == 5000) {
				int i_Escopo = 0;
				Console.WriteLine ("int i_Escopo: " + i_Escopo);
			}

			// Não funciona fora do escopo
			//Console.WriteLine ("Fora do escopo: "+ i_Escopo);


			// Conversao de tipos
			Console.WriteLine ("\n\n\n");


			int i_Convert = 30;
			string textoConvertInt = i_Convert.ToString ();

			Console.WriteLine ("Conversao de Int to String: " + textoConvertInt);

			string textoConvertStringToInt = "50";
			int i_ConvertStringToInt = Convert.ToInt32(textoConvertStringToInt);

			Console.WriteLine ("Conversao de String to Int: " + i_ConvertStringToInt);

			int i_ConvertIntToFloat = 50;
			float float_ConvertIntToFloat = i_ConvertIntToFloat;
			
			Console.WriteLine ("Conversao de Int to Float: " + float_ConvertIntToFloat);

			decimal d_ConvertDecimalToInt = 50.2M;
			int i_ConvertDecimalToInt = (int) d_ConvertDecimalToInt;

			Console.WriteLine ("Conversao de Decimal to Int: " + i_ConvertDecimalToInt);


		}

		public void metodo1() {}

		public void Test()
		{
			// Aqui funciona OK.
			Console.WriteLine ("long a_EscopoClasse:" + a_EscopoClasse);
		}

	}

}
