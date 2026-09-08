/*03. Escreva um programa que leia a idade de uma pessoa, o tipo de habilitação que ela possui e o tempo 
que ela possui carteira de habilitação. Verifique e informe se a pessoa possui os requisitos necessários para 
tirar uma carteira de habilitação do tipo D. Caso ela não possua os requisitos, indique em uma mensagem 
o motivo pelo qual ela não possui permissão.
 Requisitos carteira habilitação tipo D:
1. Ter 21 anos completos;
2. Estar habilitado no mínimo há 2 anos na categoria B ou 1 ano na categoria C*/

namespace mentoria
{
    internal class Exercicio03
    {
        public static void Executar()
        {
            
            Console.WriteLine("Este é um programa para verificar se uma pessoa possui os requisitos necessários para tirar uma carteira de habilitação do tipo D.");
            int idade, tempo;
            char tipo;
            Console.Write("Informe sua idade: ");
            idade = int.Parse(Console.ReadLine()!);

            Console.Write("Informe o tempo de habilitação (em anos): ");
            tempo = int.Parse(Console.ReadLine()!); 

            Console.Write("Informe o tipo de habilitação: ");
            tipo = char.Parse(Console.ReadLine()!);

            if(idade >= 21)
            {
                if (tipo == 'B')
                {
                    if (tempo >= 2)
                    {
                        Console.WriteLine("Você possui os requisitos necessários para tirar a carteira de habilitação do tipo D.");
                    }
                    else
                    {
                        Console.WriteLine("Você não possui tempo suficiente de habilitação na categoria B para tirar a carteira de habilitação do tipo D.");
                    }
                }
                else if (tipo == 'C')
                {
                    if (tempo >= 1)
                    {
                        Console.WriteLine("Você possui os requisitos necessários para tirar a carteira de habilitação do tipo D.");

                    }
                    else
                    {
                        Console.WriteLine("Você não possui tempo suficiente de habilitação na categoria C para tirar a carteira de habilitação do tipo D.");
                    }
                }
                else
                {
                    Console.WriteLine("Você não possui habilitação na categoria B ou C para tirar a carteira de habilitação do tipo D.");
                }
            }
            else
            {
                Console.WriteLine("Você não possui idade suficiente para tirar a carteira de habilitação do tipo D.");
            }


        }
    }
}