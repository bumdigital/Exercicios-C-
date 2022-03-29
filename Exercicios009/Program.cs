using System;

namespace Exercicios009
{
    class Program
    {
        //9) Faça um programa que leia um número
        //Inteiro qualquer e mostre na tela a sua tabuada.
        static void Main(string[] args)
        {
            int n1;
            Console.Write("Digite um numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("###############");
            Console.WriteLine($"Tabuada de {n1}");
            Console.WriteLine("###############");
            for (int i = 1; i <= 10; i++)
            {
                int result = n1 * i;
                Console.WriteLine($"{n1} X {i} = {result}");
            }
        }
    }
}
