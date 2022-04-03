using System;

namespace Exercicio055
{
    //55) Faça um programa que leia o peso de cinco
    //pessoas. No final, mostre qual foi o maior
    //e o menor peso lidos.
    class Program
    {
        static void Main(string[] args)
        {
            float maior = 0;
            float menor = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Digite o peso da {i}° pessoa: ");
                float peso = float.Parse(Console.ReadLine());
                if (i == 1)
                {
                    maior = peso;
                    menor = peso;
                }
                if (peso > maior)
                {
                    maior = peso;
                }
                if (peso < menor)
                {
                    menor = peso;
                }
            }
            Console.WriteLine($"O MAIOR peso é: {maior}");
            Console.WriteLine($"O MENOR peso é: {menor}");
        }
    }
}
