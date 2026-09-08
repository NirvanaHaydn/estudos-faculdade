/*02. Escreva um programa que leia 3 idades. Imprima a menor e a maior idade.*/

namespace mentoria
{
    internal class Exercicio02
    {
        public static void Executar()
        {
            
            Console.WriteLine("Este é um programa para ler 3 idades e imprimir a menor e a maior.");

            int idade1, idade2, idade3, menor, maior;
            Console.WriteLine("Informe a primeira idade: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a segunda idade: ");
            idade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a terceira idade: ");
            idade3 = int.Parse(Console.ReadLine());

            menor = idade1;
            maior = idade1;

            if(idade2 < menor)
            {
                menor = idade2;
            }
            if(idade3 < menor)
            {
                menor = idade3;
            }

            if(idade2 > maior)
            {
                maior = idade2;
            }
            if(idade3 > maior)
            {
                maior = idade3;
            }
            Console.WriteLine($"A menor idade é: {menor}");
            Console.WriteLine($"A maior idade é: {maior}");



            /*if (idade1 < idade2 && idade1 < idade3)
            {
                Console.WriteLine($"A menor idade é: {idade1}");
            }
            else if (idade2 < idade1 && idade2 < idade3)
            {
                Console.WriteLine($"A menor idade é: {idade2}");

            }
            else
            {
                Console.WriteLine($"A menor idade é: {idade3}");
            }
            if(idade1 > idade2 && idade1 > idade3)
            {
                Console.WriteLine($"A maior idade é: {idade1}");
            }
            else if (idade2 > idade1 && idade2 > idade3)
            {
                Console.WriteLine($"A maior idade é: {idade2}");
            }
            else
            {
                Console.WriteLine($"A maior idade é: {idade3}");
            }*/

        } 
    }

}