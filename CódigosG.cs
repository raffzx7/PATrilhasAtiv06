using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main()
		{		 
			int[] vetorA = new int[5];
			int[] vetorB = new int[5];
			int[] vetorSoma = new int[5];
			
			Console.WriteLine("insira 5 valores para o vetorA: ");
			for (int i = 0; i < vetorA.Length; i++)
			{
				Console.Write("Valor {0}: ", i + 1);
				vetorA[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Insira 5 valores para o vetorB: ");
			for (int i = 0; i < vetorB.Length; i++)
			{
				Console.Write("Valor {0}: ", i + 1);
				vetorB[i] = int.Parse(Console.ReadLine());
			}			
			for (int i = 0; i < vetorSoma.Length; i++)
			{
				vetorSoma[i]
					= vetorA[i] + vetorB[i];
			}
			Console.Clear();
			Console.WriteLine("\nVetor A: " + string.Join(", ", vetorA));
       		Console.WriteLine("Vetor B: " + string.Join(", ", vetorB));
       		Console.WriteLine("Vetor Soma: " + string.Join(", ", vetorSoma));
			Console.WriteLine();
			Console.ReadKey(true);
		}

	}

}
