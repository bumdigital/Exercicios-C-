using System;
using System.Collections.Generic;

namespace Exercicio080
{
    //80) Crie um programa onde o usuário possa digitar cinco
    //valores numéricos e cadastre-os em uma lista, já na posição
    //correta de inserção (sem usar o sort()). No final, mostre
    //a lista ordenada na tela.
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int maior = 0;
            int menor = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Digite o {i}° numero: ");
                int numero = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    maior = numero;
                    menor = numero;
                    numeros.Add(numero);
                } 
                for (int j = 0; j < numeros.Count; j++) 
                { 
                    if (numero >= maior)
                    {
                        maior = numero;
                        numeros.Insert(j+1, maior);
                    } else if (numero <= menor)
                    {
                        menor = numero;
                        numeros.Insert(j-1, menor);
                    }
                }
            }
            foreach (int i in numeros)
            {
                Console.Write($"{i} - ");
            }
        }
    }
}
