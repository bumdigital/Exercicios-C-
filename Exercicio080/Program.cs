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
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o {i+1}° numero: ");
                int numero = int.Parse(Console.ReadLine());
                if (i == 0 || numero > numeros[numeros.Count-1])
                {
                    Console.WriteLine($"O numero {numero} foi adicionado ao final da lista");
                    numeros.Add(numero);
                } else 
                { 
                    for (int j = 0; j < numeros.Count; j++) 
                    { 
                        if (numero <= numeros[j])
                        {
                            numeros.Insert(j, numero);
                            Console.WriteLine($"O numero {numero} foi adicionado na " +
                                $"posição {j} da lista");
                            break;
                        }
                    }
                }
            }
            int contador = 0;
            Console.WriteLine("####################################");
            foreach (int c in numeros)
            {
                contador++;
                string ifen = contador == numeros.Count ? "" : " - ";
                Console.Write($"{c}{ifen}");
            }
            Console.WriteLine();
            Console.WriteLine("####################################");
        }
    }
}
