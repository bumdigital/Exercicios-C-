using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio085
{
    //85) Crie um programa onde o usuário possa digitar
    //sete valores numéricos e cadastre-os em uma lista
    //única que mantenha separados os valores pares e ímpares.
    //No final, mostre os valores pares e ímpares em ordem crescente.
    class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>();
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Digite o {i+1}° numero: ");
                valores.Add(int.Parse(Console.ReadLine()));
            }
            List<int> ordenado = valores.OrderBy(x => x).ToList();
            Console.Write("Numrtos pares: ");
            foreach (int i in ordenado)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                } 
            }
            Console.WriteLine();
            Console.Write("Numrtos impares: ");
            foreach (int i in ordenado)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
