using System;
using System.Collections.Generic;

namespace Exercicio087
{
    //87) Aprimore o desafio anterior, mostrando no final: 
    //A) A soma de todos os valores pares digitados.
    //B) A soma dos valores da terceira coluna.
    //C) O maior valor da segunda linha.
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> valores = new List<List<int>>();
            List<int> valores0 = new List<int>();
            List<int> valores1 = new List<int>();
            List<int> valores2 = new List<int>();
            int somaPares = 0;
            int somaTerColuna = 0;
            int maiorSegLinha = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Digite um valor para [ {i} , {j} ]: ");
                    int numero = int.Parse(Console.ReadLine());
                    if (numero % 2 == 0)
                    {
                        somaPares += numero;
                    }
                    if (j == 0)
                    {
                        valores0.Add(numero);
                    } else if (j == 1)
                    {
                        valores1.Add(numero);
                    } else if (j == 2)
                    {
                        valores2.Add(numero);
                        somaTerColuna += numero;
                    }
                    if (i == 1 && j == 0)
                    {
                        maiorSegLinha = numero;
                    } else if (i == 1 && numero > maiorSegLinha)
                    {
                        maiorSegLinha = numero;
                    }
                    valores.Add(valores0);
                    valores.Add(valores1);
                    valores.Add(valores2);
                }
            }
            Console.WriteLine($"################################################");
            for (int i = 0; i < valores0.Count; i++)
            {
                for (int j = 0; j < valores0.Count; j++)
                {
                    Console.Write($"[ {valores[j][i]} ] ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"################################################");
            Console.WriteLine($"A soma de todos os valores pares digitados é {somaPares}");
            Console.WriteLine($"A soma dos valores da terceira coluna é {somaTerColuna}");
            Console.WriteLine($"O maior valor da segunda linha é {maiorSegLinha}");
            Console.WriteLine($"################################################");
        }
    }
}
