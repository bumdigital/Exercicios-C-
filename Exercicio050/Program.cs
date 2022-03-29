using System;
using System.Threading;

namespace Exercicio050
{
    //50) Desenvolva um programa que leia seis números
    //inteiros e mostre a soma apenas daqueles que forem
    //pares. Se o valor digitado for ímpar, desconsidere-o.
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[6];           
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Digite {i+1}°: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            int acumulador = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    acumulador += numeros[i];
                    Console.WriteLine(numeros[i]);
                    Thread.Sleep(150);
                }
            }
            Console.WriteLine($"A soma dos numeros pares digitados é {acumulador}");
        }
    }
}
