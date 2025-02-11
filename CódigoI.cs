using System;

namespace PATrilhasAtiv06
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("Esses são todos os números primos entre 1 e 100:  ");
			
			for(int contador1 = 2; contador1 < 100; contador1++)
			{
				bool Numeroprimo = true;
			
				for (int contador2 = 2; contador2 <=Math.Sqrt(contador1); contador2++)
					{
						
						if (contador1 % contador2 == 0)
						{
							Numeroprimo = false;
							break;
						}
				     }
				if (Numeroprimo)
				{
				Console.Write(contador1+ " ");
				}
			}
			Console.WriteLine();
			Console.ReadKey(true);
		}
    
	}
  
}
