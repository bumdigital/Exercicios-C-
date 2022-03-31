using System;

namespace Exercicio052
{
    class Program
    {
        //52) Faça um programa que leia um número inteiro
        //e diga se ele é ou não um número primo.
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());
            int acumulador = 0;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    acumulador += 1;
                }
            }
            if (acumulador == 2)
            {
                Console.WriteLine($"O numero {numero} É PRIMO");
            } else
            {
                Console.WriteLine($"O numero {numero} NÃO É PRIMO");
            }
        }
    }
}
