using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main()
		{		
			int[] 	Inteiros = new int[] {10, 20,30,12};
			
			Console.WriteLine("Esses são os elementos deste vetor: ");
			
			for (int i = 0; i < Inteiros.Length; i++)
			{
				Console.WriteLine(Inteiros[i]);
			}
			Console.ReadKey(true);
		}

	}

}
