using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        bool ehPrimo = true;

        if (numero <= 1)
        {
            ehPrimo = false; 
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    ehPrimo = false;
                    break;
                }
            }
        }

        if (ehPrimo)
        {
            Console.WriteLine("{0} é um número primo.", numero);
        }
        else
        {
            Console.WriteLine("{0} não é um número primo.", numero);
        }

			Console.WriteLine("\n\rPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
