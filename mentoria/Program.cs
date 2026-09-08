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