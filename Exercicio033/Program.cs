using System;

namespace Exercicio033
{
    //33) Faça um programa que leia três números e
    //mostre qual é o maior e qual é o menor.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro numero: ");
            int n3 = int.Parse(Console.ReadLine());

            int maior = 0;
            int menor = 0;

            if (n1 > n2)
            {
                maior = n1;
                menor = n2;
            } else
            {
                maior = n2;
                menor = n1;
            }
            if (n3 > maior)
            {
                maior = n3;
            }
            if (n3 < menor)
            {
                menor = n3;
            }
            Console.WriteLine($"O maior numero é {maior}\nO menor numero é {menor}");
        }
    }
}
