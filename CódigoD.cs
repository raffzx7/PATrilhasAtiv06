using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main()
		{				
			int soma = 0;
			
			Console.WriteLine("Insira um número: ");
			var numero = int.Parse(Console.ReadLine());
			Console.WriteLine( );
			
			for (int contador = 0; 	contador < numero; contador++){			
				soma += contador;
			}
			Console.WriteLine("A soma dos números é {0}", soma);
			Console.ReadKey(true);
		}
    
	}
  
}
