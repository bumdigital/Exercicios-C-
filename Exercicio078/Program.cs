using System;
using System.Collections.Generic;

namespace Exercicio078
{
    //78) Faça um programa que leia 5 valores numéricos
    //e guarde-os em uma lista. No final, mostre qual
    //foi o maior e o menor valor digitado e as suas
    //respectivas posições na lista. 
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int maior = 0;
            int menor = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o numero da posição {i} da lista: ");
                numeros.Add(int.Parse(Console.ReadLine()));
                if (i == 0)
                {
                    maior = numeros[i];
                    menor = numeros[i];
                } else if (numeros[i] > maior)
                {
                    maior = numeros[i];
                } else if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }
            Console.WriteLine($"O maior numero digitado foi {maior} e sua posição " +
                $"na lista é {numeros.IndexOf(maior)}");
            Console.WriteLine($"O menor numero digitado foi {menor} e sua posição " +
                $"na lista é {numeros.IndexOf(menor)}");
        }
    }
}
