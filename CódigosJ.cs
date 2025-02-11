using System;

class Program
{
    static void Main()
    {
    	string[] nomemercadoria = new string[40];
    	int[] 	quantidadeestoque = new int[40];
    	double[] precounitario = new double[40];
    	
    	while (true)
    	{
    			
			Console.WriteLine("================================================= ");
			Console.WriteLine("                    	MENU");
			Console.WriteLine("1. Cadastro");
			Console.WriteLine("2. Exibe valor total");
			Console.WriteLine("3. Sair");
			Console.WriteLine("================================================= ");
			
			Console.WriteLine("OPÇÃO:");
			string escolha = Console.ReadLine();
			Console.Clear();
			
			switch (escolha)
			{
				case "1": 
					bool continuarCadastro = true;
                    int i = 0;
                                       
                    while(continuarCadastro && i < nomemercadoria.Length)
                    {
					
						Console.WriteLine("Mercadoria {0}: ", i+1);
						nomemercadoria[i] = Console.ReadLine();
						
						Console.WriteLine("Preço {0}: ", i+1);
						precounitario[i] = double.Parse(Console.ReadLine());
						
						Console.WriteLine("Quantidade da mercadoria {0}: ", i+1 );
						quantidadeestoque[i] = int.Parse(Console.ReadLine());
						
						Console.WriteLine("Deseja continuar a operação (sim/não)? ");
						string opcao = Console.ReadLine();
						
						if (opcao == "não" || opcao == "nao")
						{
							Console.Clear();
							break;
						}
						else if (opcao != "sim")
						{
							Console.WriteLine("Opção inválida, voltando para o menu....");
							break;
						}	
						else
						{
							i++;
						}
						
			}
    		break;
    			
    			case "2":
    				
    				double totalvalor = 0;
    				for (int j = 0; j < nomemercadoria.Length; j++) 
    				{
    					if (quantidadeestoque[j] > 0)
    				{
    					totalvalor += quantidadeestoque[j] * precounitario[j];
    				}
       				}
    				Console.WriteLine("O valor total das mercadorias é {0:C}.", totalvalor);
    				Console.WriteLine();
    				break;
    			
    				
    			case "3":
    				
    				Console.WriteLine("Saindo...");
    				return;
    			
    			default:
    				Console.WriteLine("Opção inválida!");
    				break;
    	}

    }

	}

}
