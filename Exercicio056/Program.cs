using System;

namespace Exercicio056
{
    //56) Desenvolva um programa que leia o nome,
    //idade e sexo de 4 pessoas. No final do programa,
    //mostre: a média de idade do grupo, qual é o nome
    //do homem mais velho e quantas mulheres têm
    //menos de 20 anos.
    class Program
    {
        static void Main(string[] args)
        {
            int mulheresMenosDe20 = 0;
            int homemMaisVelho = 0;
            string nomeHomemMaisVelho = "";
            int media = 0;
            int acumulador = 0;
            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"{i}° pessoa. Digite o nome: ");
                string nome = Console.ReadLine();
                Console.Write($"{i}° pessoa. Digite a idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write($"{i}° pessoa. Digite o sexo: ");
                string sexo = Console.ReadLine().ToUpper();
                Console.WriteLine("############################");
                acumulador += idade;
                media = acumulador / i;
                if (idade < 20 && sexo == "F")
                {
                    mulheresMenosDe20 += 1;
                }
                if (idade > homemMaisVelho && sexo == "M")
                {
                    homemMaisVelho = idade;
                    nomeHomemMaisVelho = nome;
                }
            }
            Console.WriteLine($"A média das idades é {media}");
            Console.WriteLine($"O nome do homem mais velho é {nomeHomemMaisVelho}");
            Console.WriteLine($"A quantidade de mulheres com menos de 20 anos é " +
                $"{mulheresMenosDe20}");
        }
    }
}
