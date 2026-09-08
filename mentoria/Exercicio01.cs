namespace mentoria
{
    internal class Exercicio01
    {
        public static void Executar()
        {
            int numero;

            Console.WriteLine("Este é um programa para ler um número inteiro entre 0 e 5 e imprimir o seu equivalente por extenso.");

			Console.WriteLine("Informe um número inteiro: ");
            numero = int.Parse(Console.ReadLine()!);

            if (numero >= 0 && numero <= 5)
            {
                if (numero == 0)
                    Console.WriteLine("Zero");
                else if (numero == 1)
                    Console.WriteLine("Um");
                else if (numero == 2)
                    Console.WriteLine("Dois");
                else if (numero == 3)
                    Console.WriteLine("Três");
                else if (numero == 4)
                    Console.WriteLine("Quatro");
                else
                    Console.WriteLine("Cinco");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }
    }
}