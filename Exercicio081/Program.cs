using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio081
{
    //81) Crie um programa que vai ler vários números e colocar 
    //    em uma lista. Depois disso, mostre:
    //A) Quantos números foram digitados.
    //B) A lista de valores, ordenada de forma decrescente.
    //C) Se o valor 5 foi digitado e está ou não na lista.

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            string continuar = "S";
            int digitados = 0;
            int digi5 = 0;
            while (continuar != "N")
            {
                Console.Write("Digite um numero: ");
                numeros.Add(int.Parse(Console.ReadLine()));
                digitados++;
                if (numeros[digitados-1] == 5)
                {
                    digi5++; 
                }
                Console.Write("Quer continuar? [S/N]: ");
                continuar = Console.ReadLine().ToUpper();
                while (continuar != "S" && continuar != "N")
                {
                    Console.Write("Valor invalido! Para continuar digite S e para " +
                        "encerrar digite N. [S/N]: ");
                    continuar = Console.ReadLine().ToUpper();
                }
            }
            Console.WriteLine("#########################################");
            Console.WriteLine($"Foram digitados {digitados} numeros");
            List<int> ordenado = numeros.OrderBy(x => x).ToList();
            List<int> invertido = Enumerable.Reverse(ordenado).ToList();
            Console.Write("A ordem decrescente dos numeros digitados é ");
            for (int i = 0; i < invertido.Count; i++) 
            {
                string ifen = i != invertido.Count - 1? " - " : "";
                Console.Write($"{invertido[i]}{ifen}");
            }
            Console.WriteLine();
            if (digi5 == 0)
            {
                Console.WriteLine("O numero 5 não foi digitado");
            } else
            {
                Console.WriteLine($"O numero 5 foi digitado {digi5} vezes");
            }
            Console.WriteLine("#########################################");
        }
    }
}
