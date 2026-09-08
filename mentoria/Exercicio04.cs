/*05. Escreva um programa que leia quatro números inteiros positivos (w, x, y e z) e efetue o cálculo
de uma das seguintes médias de acordo com o valor de w conforme a tabela a seguir*/

namespace mentoria
{
    internal class Exercicio04
    {
        public static void Executar()
        {
            int w, x, y, z;
            double media;

            Console.Write("Informar o valor de w: ");
            w = int.Parse(Console.ReadLine()!);
            if(w >= 1 && w <= 4)
            {


                Console.Write("Informar o valor de x: ");
                x = int.Parse(Console.ReadLine()!);

                Console.Write("Informar o valor de y: ");
                y = int.Parse(Console.ReadLine()!);

                Console.Write("Informar o valor de z: ");
                z = int.Parse(Console.ReadLine()!);

                if(w == 1) //media geometrica
                {
                    media = Math.Sqrt((x * y * z));
                    Console.WriteLine($"A média geométrica resultante é: {media}");
                }
                else if(w == 2) //media ponderada
                {
                    media = (x + 2 * y + 3 * z) / 6.0;
                    Console.WriteLine($"A média ponderada resultante é: {media}");
                }
                else if(w == 3)//media harmonica
                {
                    media = 1 / (1/ (double) x + 1 / (double) y + 1 / (double) z);
                    Console.WriteLine($"A média harmônica resultante é: {media}");
                }
                else//media aritmetica
                {
                    media = (double)(x + y + z) / 3;
                    Console.WriteLine($"A média aritmética resultante é: {media}");
                }
            }
            else
            {
                Console.WriteLine("Valor de w inválido. Por favor, insira um valor entre 1 e 4.");
            }

        }
    }
}