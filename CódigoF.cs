using System;

namespace PATrilhasAtiv06
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("Qual será o tamanho da sequência:  ");
			var quantidade = int.Parse(Console.ReadLine());
			
			if (quantidade <= 0) {
				Console.WriteLine("A quantidade deve ser maior que zero.");
				return;
			}
			
			Console.WriteLine();
			
			int numeroMaior = int.MinValue;
			
			for (int contador = 1;contador <= quantidade; contador++)
			{
				Console.WriteLine("{0}º número:", contador);
				var numero = int.Parse(Console.ReadLine());
				
				if (numero > numeroMaior)
				{
					numeroMaior = numero;
				}
			}
			Console.WriteLine("\n\rO maior núemro dessa sequência é : {0}", numeroMaior);
			Console.ReadKey(true);
		}
    
	}
  
}
