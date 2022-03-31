using System;

namespace Exercicio054
{
    //54) Crie um programa que leia o ano de nascimento
    //de sete pessoas. No final, mostre quantas pessoas
    //ainda não atingiram a maioridade e quantas já são
    //maiores.
    class Program
    {
        static void Main(string[] args)
        {
            int maiorIdade = 0;
            int menorIdade = 0;
            int anoAtual = DateTime.Now.Year;
            for (int i = 1; i <= 7; i++)
            {
                Console.Write($"Digite o ano de nascimento da {i}° pessoa: ");
                int ano = int.Parse(Console.ReadLine());
                int idade = anoAtual - ano;
                if (idade < 18)
                {
                    menorIdade += 1;
                } else
                {
                    maiorIdade += 1;
                }
            }
            Console.WriteLine($"{menorIdade} pessoas são menores de idade e " +
                $"{maiorIdade} são maiores de idade.");
        }
    }
}
