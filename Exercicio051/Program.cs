using System;
using System.Threading;

namespace Exercicio051
{
    //51) Desenvolva um programa que leia o primeiro
    //termo e a razão de uma PA. No final, mostre os
    //10 primeiros termos dessa progressão.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro termo da PA: ");
            int primeiroTermo = int.Parse(Console.ReadLine());
            Console.Write("Digite a razão da PA: ");
            int razao = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}° Termo da PA:{primeiroTermo}");
                primeiroTermo += razao;
                Thread.Sleep(150);
            }
        }
    }
}
