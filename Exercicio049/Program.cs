using System;
using System.Threading;

namespace Exercicio049
{
    //48) Faça um programa que calcule a soma
    //entre todos os números que são múltiplos
    //de três e que se encontram no intervalo
    //de 1 até 500.
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            for (int i = 1; i<=500; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(100);
                    acumulador += i;
                }
            }
            Console.WriteLine("A soma de todos multiplos de 3 " +
                $"no intervalo de 1 a 500 é {acumulador}");
        }
    }
}
