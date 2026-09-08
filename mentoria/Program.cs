using System;
using System.Collections.Generic;

namespace mentoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.Clear();

                Console.WriteLine("===== LISTA DE EXERCÍCIOS =====");
                Console.WriteLine("1 - Exercício 01");
                Console.WriteLine("2 - Exercício 02");
                Console.WriteLine("3 - Exercício 03");
                Console.WriteLine("4 - Exercício 04");
                Console.WriteLine("5 - Exercício 05");
                Console.WriteLine("6 - Exercício 06");
                Console.WriteLine("7 - Exercício 07");
                Console.WriteLine("8 - Exercício 08");
                Console.WriteLine("9 - Exercício 09");
                Console.WriteLine("10 - Exercício 10");
                Console.WriteLine("11 - Exercício 11");
                Console.WriteLine("12 - Exercício 12");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("===============================");
                Console.Write("Escolha um exercício: ");

                opcao = int.Parse(Console.ReadLine()!);

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Exercicio01.Executar();
                        break;
                    case 2:
                        Exercicio02.Executar();
                        break;
                    case 3:
                        Exercicio03.Executar();
                        break;
                    case 4:
                        Exercicio04.Executar();
                        break;
                    case 5:
                        Exercicio05.Executar();
                        break;
                    case 6:
                        Exercicio06.Executar();
                        break;
                    case 7:
                        Exercicio07.Executar();
                        break;
                    case 8:
                        Exercicio08.Executar();
                        break;
                    case 9:
                        Exercicio09.Executar();
                        break;
                    case 10:
                        Exercicio10.Executar();
                        break;
                    case 11:
                        Exercicio11.Executar();
                        break;
                    case 12:
                        Exercicio12.Executar();
                        break;
                    case 0:
                        Console.WriteLine("Encerrando...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }

            } while (opcao != 0);
        }
    }
}