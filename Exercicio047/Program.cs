using System;
using System.Threading;

namespace Exercicio047
{
    //47) Crie um programa que mostre na tela todos
    //os números pares que estão no intervalo entre
    //1 e 50.
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<=50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(500);
                }
            }
        }
    }
}
