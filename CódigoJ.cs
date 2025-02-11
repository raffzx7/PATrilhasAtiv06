using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main()
		{		
			Console.WriteLine("O resultado da soma de todos os números pares entre 1 e 100 é:");
			
			int soma = 0;	
			
			for (int contador = 0; 	contador < 101; contador++){
				
				if (contador % 2 == 0) {
					soma += contador;
				}
			
			}
			Console.WriteLine(soma);
			Console.ReadKey(true);
		}
    
	}
  
}
