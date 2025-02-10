using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main()
		{				
			Console.WriteLine("Digite uma palavra: ");
			string palavra = Console.ReadLine();
			Console.WriteLine( );
			
			for (int contador = 0; 	contador < palavra.Length; contador++){			
				Console.WriteLine(palavra[contador]);
			}
	
			Console.WriteLine("\n\rPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
