using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main()
		{		
			string[] alunos = new string[5]; 
			double[,] notas = new double[5, 2];
			double[] medias = new double[5];
			
			for (int i = 0; i < alunos.Length; i++)
			{
				Console.WriteLine("\n\rNome do {0}º aluno: ", i + 1);
				alunos[i] = Console.ReadLine();
				
				double somadeNotas = 0;
				
				for (int y = 0; y < notas.GetLength(1); y++)
				{
					Console.WriteLine("Nota {0} do {1}º aluno: ", y + 1, i + 1);
					notas[i, y] = double.Parse(Console.ReadLine());
					somadeNotas += notas[i, y];
				}	
				medias[i] = somadeNotas / notas.GetLength(1);			
			}
			Console.Clear();
			Console.WriteLine("\nLista de Alunos, Notas e Média:");
			for (int i = 0; i < alunos.Length; i++)
			{
				Console.Write("\n{0}º Aluno: {1} - Notas: ", i + 1, alunos[i]);
				
				for (int y = 0; y < notas.GetLength(1); y++)
				{
					Console.Write(notas[i, y] + " ");
				}
				Console.Write(" - Média: {0:F2}", medias[i]);
			}	
			Console.WriteLine();
			Console.ReadKey(true);
		}

	}

}
