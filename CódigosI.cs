using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main()
		{		 
			string[]   nomes = new string[10];
				
			Console.WriteLine("Insira 10 nomes para o vetror: ");
			Console.WriteLine();
			
			for (int i = 0; i < nomes.Length; i++)
			{	
				Console.Write("Nome {0}: ", i+1);
				nomes[i] = Console.ReadLine();
			}
      
			Console.Clear();
			Console.WriteLine();
			Console.WriteLine("Lista com os nomes: ");
			
			for (int i = 0; i < nomes.Length; i++)
			{
				Console.WriteLine(nomes[i]);
			}
			Console.WriteLine();
			Console.ReadKey(true);
		}
    
	}
  
}
