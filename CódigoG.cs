using System;

namespace PATrilhasAtiv06
{
	class Program
	{
		public static void Main()
		{
			for (int contador = 5; contador < 11; contador++)
			{
				for (int contador2 = 0; contador2 < 11; contador2++)
				{
					int resultado = contador2 * contador;
					
					Console.WriteLine(+contador+ "·" +contador2+ " = " +resultado);
					
					if (contador2 == 10)
					{
						Console.WriteLine("==========");
					}
				}		
			}
			Console.ReadKey(true);
		}
    
	}
  
}
