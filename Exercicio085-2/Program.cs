using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio085_2
{
    //85) Crie um programa onde o usuário possa digitar
    //sete valores numéricos e cadastre-os em uma lista
    //única que mantenha separados os valores pares e ímpares.
    //No final, mostre os valores pares e ímpares em ordem crescente.

    class ParImpar
    {
        public List<int> Pares { get; set; }
        public List<int> Impares { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //paresMatriz();
            paresObjeto();
        }

        private static void paresObjeto()
        {
            ParImpar valores = new ParImpar();
            List<int> listaPares = new List<int>();
            List<int> listaImpares = new List<int>();

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Digite o {i + 1}° numero: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    listaPares.Add(numero);
                }
                else
                {
                    listaImpares.Add(numero);
                }
                valores.Pares = listaPares;
                valores.Impares = listaImpares;
            }
            Console.Write("Pares ");
            foreach(var numero in valores.Pares)
            {
                Console.Write($"{numero}");
            }

            Console.Write("Impares ");
            foreach(var numero in valores.Impares)
            {
                Console.Write($"{numero}");
            }
        }

        private static void paresMatriz()
        {
            List<List<int>> valores = new List<List<int>>();
            for (int i = 0; i < 7; i++)
            {
                List<int> listaPares = new List<int>();
                List<int> listaImpares = new List<int>();
                Console.Write($"Digite o {i + 1}° numero: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    listaPares.Add(numero);
                }
                else
                {
                    listaImpares.Add(numero);
                }
                valores.Add(listaPares);
                valores.Add(listaImpares);
            }
            Console.Write("Pares ");
            for (int i = 0; i < valores[0].Count; i++)
            {
                Console.Write($"{valores[0][i]} ");
            }
            Console.Write("Impares ");
            for (int i = 0; i < valores[1].Count; i++)
            {
                Console.Write($"{valores[1][i]} ");
            }
        }
    }
}
