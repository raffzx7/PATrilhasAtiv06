using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main()
		{		 
			decimal[] valores = new decimal[5] {30, 20, 10, 13, 18};
			decimal somadeValores = 0;
			
			Console.WriteLine("Os valores do vetor são: ");
			
			for (int i = 0; i < valores.Length; i++)
			{
				Console.Write(valores[i]+" ");
				somadeValores += valores[i];
			}             	
			decimal media = somadeValores / valores.Length;
				
			Console.WriteLine();
			Console.WriteLine("\n\rE a média entre eles é: " +media);
			
			Console.WriteLine();
			Console.ReadKey(true);
		}

	}

}
