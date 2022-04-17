using System;
using System.Collections.Generic;

namespace Exercicio082
{
    //82) Crie um programa que vai ler vários números e
    //colocar em uma lista. Depois disso, crie duas listas
    //extras que vão conter apenas os valores pares e os
    //valores ímpares digitados, respectivamente. Ao final,
    //mostre o conteúdo das três listas geradas.
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            List<int> par = new List<int>();
            List<int> impar = new List<int>();
            string continuar = "S";
            int contador = 0;
            while (continuar != "N")
            {
                Console.Write("Digite um numero: ");
                numeros.Add(int.Parse(Console.ReadLine()));
                contador++;
                if (numeros[contador-1] % 2 == 0)
                {
                    par.Add(numeros[contador-1]);
                } else
                {
                    impar.Add(numeros[contador-1]);
                }
                Console.Write("Quer continuar? [S/N]: ");
                continuar = Console.ReadLine().ToUpper();
                while (continuar != "N" && continuar != "S")
                {
                    Console.Write("Valor invalido! Para continuar digite S e para " +
                        "encerrar digite N. [S/N]: ");
                    continuar = Console.ReadLine().ToUpper();
                }
            }
            Console.WriteLine("####################################################");
            Console.Write("Numeros digitos: ");
            for (int i = 0; i < numeros.Count; i++)
            {
                string ifen = i == numeros.Count - 1 ? "" : " - ";
                Console.Write($"{numeros[i]}{ifen}");
            }
            Console.WriteLine();
            Console.Write("Valores par: ");
            for (int i = 0; i < par.Count; i++)
            {
                string ifen = i == par.Count - 1 ? "" : " - ";
                Console.Write($"{par[i]}{ifen}");
            }
            Console.WriteLine();
            Console.Write("Valores impar: ");
            for (int i = 0; i < impar.Count; i++)
            {
                string ifen = i == impar.Count -1? "" : " - ";
                Console.Write($"{impar[i]}{ifen}");
            }
            Console.WriteLine();
            Console.WriteLine("####################################################");
        }
    }
}
