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
            float guardandoMenor = menor;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Digite o peso da {i}° pessoa: ");
                float peso = float.Parse(Console.ReadLine());
                if (peso > maior)
                {
                    maior = peso;
                }
                if (peso < maior)
                {
                    menor = peso;
                }
                if (peso < guardandoMenor)
                {
                    menor = guardandoMenor;
                }
            }
            Console.WriteLine($"Maior: {maior}");
            Console.WriteLine($"Maior: {menor}");

        }
    }
}
