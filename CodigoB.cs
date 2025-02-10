using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main()
		{				
			Console.WriteLine("insira um número inteiro positivo: ");
			var numero = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Os números pares entre {0} e 0 são: ", numero);
			for (int contador = 1; 	contador < numero; contador++){
		
				if (contador % 2 == 0) {
					Console.Write(contador+ " ");
				}
			
			}
			Console.WriteLine( );
			Console.ReadKey(true);
		}
    
	}
  
}
