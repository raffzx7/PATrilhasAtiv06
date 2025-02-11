using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main()
		{		 
			Console.WriteLine("Escolha o tamanho do vetor: ");
			var tamanho = int.Parse(Console.ReadLine());
			Console.WriteLine();
			
			int[] valores = new int[tamanho];			
			int menorvalor = int.MaxValue;
			
			if (tamanho <= 0)
			{
				Console.WriteLine("Valor inválido!");
				return;
			}
				
			for (int i = 0; i < valores.Length; i++)
			{
				Console.WriteLine("Digite o {0}º valor do vetor: ", i + 1);
				valores[i] = int.Parse(Console.ReadLine());
			
				if (valores[i] < menorvalor)
				{
					menorvalor = valores[i];
				}
			}	
			Console.Clear();
			Console.WriteLine("O menor valor dessa sequência é : {0}", menorvalor);	
			Console.WriteLine();
			Console.ReadKey(true);
		}

	}

}
