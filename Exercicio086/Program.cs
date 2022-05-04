using System;
using System.Collections.Generic;

namespace Exercicio086
{
    //86) Crie um programa que declare uma matriz de dimensão
    //3x3 e preencha com valores lidos pelo teclado.No final,
    //mostre a matriz na tela, com a formatação correta.
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> lista = new List<List<int>>();
            List<int> lista0 = new List<int>();
            List<int> lista1 = new List<int>();
            List<int> lista2 = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Digite um valor para [{i} , {j}]: ");
                    int numero = int.Parse(Console.ReadLine());
                    if (j == 0)
                    {
                        lista0.Add(numero);
                    } else if (j == 1)
                    {
                        lista1.Add(numero);
                    } else if (j == 2)
                    {
                        lista2.Add(numero);
                    }
                    lista.Add(lista0);
                    lista.Add(lista1);
                    lista.Add(lista2);
                }
            }
            for (int i = 0; i < lista0.Count; i++)
            {
                for (int j = 0; j < lista0.Count; j++)
                {
                    Console.Write($"[ {lista[j][i]} ] ");
                }
                Console.WriteLine();
            }
        }
    }
}
