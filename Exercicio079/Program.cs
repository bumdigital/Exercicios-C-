using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio079
{
    //79) Crie um programa onde o usuário possa digitar
    //vários valores numéricos e cadastre-os em uma lista.
    //Caso o número já exista lá dentro, ele não será adicionado.
    //No final, serão exibidos todos os valores únicos digitados,
    //em ordem crescente. 
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            string continuar = "";
            while (continuar != "N")
            {
                Console.Write("Digite um numero: ");
                int digNum = int.Parse(Console.ReadLine());
                int seExiste = numeros.IndexOf(digNum);
                if (seExiste == -1)
                {
                    numeros.Add(digNum);
                } else
                {
                    Console.WriteLine("Valor duplicado! Não será adicionado na lista.");
                }
                Console.Write("Deseja continuar? [S/N]: ");
                continuar = Console.ReadLine().ToUpper();
                while (continuar != "N" && continuar != "S")
                {
                    Console.Write("Valor invalido. Digite S para continuar ou N para encerrar. [S/N]: ");
                    continuar = Console.ReadLine().ToUpper();
                }
            }
            List<int> ordenado = numeros.OrderBy(x => x).ToList();
            for (int i = 0; i < numeros.Count; i++)
            {
                Console.Write($"{ordenado[i]} - ");
            }
        }
    }
}
