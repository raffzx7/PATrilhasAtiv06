using System;

namespace PATrilhasAtiv06
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("insira um número inteiro positivo: ");
			var numero = int.Parse(Console.ReadLine());
			
			Console.WriteLine("\n\rEsses são seus divisores: ");
			
			for (int contador = 1; contador <= numero; contador++){
				
				if (numero % contador == 0) {
	
				Console.Write(+contador+ " ");
			}
		}
			Console.WriteLine();
			Console.ReadKey(true);
		}

	}
  
}
