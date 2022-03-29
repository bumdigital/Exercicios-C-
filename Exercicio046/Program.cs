using System;
using System.Threading;

namespace Exercicio046
{
    //46) Faça um programa que mostre na tela uma
    //contagem regressiva para o estouro de fogos
    //de artifício, indo de 10 até 0, com uma pausa
    //de 1 segundo entre eles.
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("PoooOOOOOWWWWWWWWWWWWW!!!!");
        }
    }
}
