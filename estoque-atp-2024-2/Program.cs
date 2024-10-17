namespace estoque_atp_2024_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DECLARACAO DE VARIAVEIS
            const int MAX = 3;
            int N = 0, opcao=0, cod, pos=0;
            bool achei;

            int[] Ids = new int[MAX];
            string[] Nomes = new string[MAX];
            double[] Precos = new double[MAX];
            int[] Qtds = new int[MAX];

            do
            {
                Console.Clear();
                // MENU DE OPCOES
                Console.WriteLine("===> ESTOQUE DE PRODUTOS <===");
                Console.WriteLine("1 - Cadastrar produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Pesquisar Produto");
                Console.WriteLine("4 - Editar Produto");
                Console.WriteLine("5 - Apagar Produto");
                Console.WriteLine("0 - Sair");
                Console.Write("Digite uma opcao: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("\nSaindo...");
                        break;
                    case 1:
                        Console.WriteLine("\n==> Cadastrar novo produto <===\n");
                        if (N == MAX)
                        {
                            Console.WriteLine("Estoque Cheio!!!\n");
                        }
                        else
                        {
                            Console.Write("Digite o código do produto: ");
                            Ids[N] = int.Parse(Console.ReadLine());
                            Console.Write("Digite o nome do produto: ");
                            Nomes[N] = Console.ReadLine();
                            Console.Write("Digite o preço do produto: ");
                            Precos[N] = double.Parse(Console.ReadLine());
                            Console.Write("Digite a quantidade do produto: ");
                            Qtds[N] = int.Parse(Console.ReadLine());

                            N++;
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nListar Produtos\n");
                        Console.WriteLine($"\nProdutos Cadastrados: {N}\n");
                        for (int i=0; i < N; i++)
                        {
                            Console.WriteLine($"{Ids[i]};{Nomes[i]};{Precos[i]:F2};{Qtds[i]};");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nPesquisar Produto\n");
                        Console.Write("Digite o código do produto: ");
                        cod = int.Parse(Console.ReadLine());
                        achei = false;
                        for (int i = 0; i < N; i++)
                        {
                            if (Ids[i] == cod)
                            {
                                Console.WriteLine($"{Ids[i]};{Nomes[i]};{Precos[i]:F2};{Qtds[i]};");
                                achei = true;
                                break;
                            }
                        }
                        if (!achei)
                        {
                            Console.WriteLine("\nProduto não encontrado!\n");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nEditar Produto\n");
                        Console.Write("Digite o código do produto: ");
                        cod = int.Parse(Console.ReadLine());
                        achei = false;
                        for (int i = 0; i < N; i++)
                        {
                            if (Ids[i] == cod)
                            {
                                Console.WriteLine($"{Ids[i]};{Nomes[i]};{Precos[i]:F2};{Qtds[i]};");
                                achei = true;
                                pos = i;
                                break;
                            }
                        }
                        if (!achei)
                        {
                            Console.WriteLine("\nProduto não encontrado!\n");
                        }
                        else
                        {
                            Console.Write("Digite o nome do produto: ");
                            Nomes[pos] = Console.ReadLine();
                            Console.Write("Digite o preço do produto: ");
                            Precos[pos] = double.Parse(Console.ReadLine());
                            Console.Write("Digite a quantidade do produto: ");
                            Qtds[pos] = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nProduto alterado com sucesso!\n");
                        }
                        break;
                    case 5:
                        Console.WriteLine("\nApagar Produto\n");
                        Console.Write("Digite o código do produto: ");
                        cod = int.Parse(Console.ReadLine());
                        achei = false;
                        for (int i = 0; i < N; i++)
                        {
                            if (Ids[i] == cod)
                            {
                                Console.WriteLine($"{Ids[i]};{Nomes[i]};{Precos[i]:F2};{Qtds[i]};");
                                achei = true;
                                pos = i;
                                break;
                            }
                        }
                        if (!achei)
                        {
                            Console.WriteLine("\nProduto não encontrado!\n");
                        }
                        else
                        {
                            N--;
                            for(int i=pos; i < N; i++)
                            {
                                Ids[i] = Ids[i + 1];
                                Nomes[i] = Nomes[i + 1];
                                Precos[i] = Precos[i + 1];
                                Qtds[i] = Qtds[i + 1];
                            }
                            Console.WriteLine("\nProduto excluido com sucesso!\n");
                        }
                        break;
                    default:
                        Console.WriteLine("\nOpcao Invalida!\n");
                        break;
                }

                Console.ReadKey();
            } while (opcao != 0);

        }
    }
}
