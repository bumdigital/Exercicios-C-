using System;

namespace Exercicio032
{
    //32) Faça um programa que leia um ano
    //qualquer e mostre se ele é bissexto.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um ano para saber se é bissexto: ");
            int ano = int.Parse(Console.ReadLine());
            if (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0)
            {
                Console.WriteLine("O ano é bissexto (tem 366 dias)");
            } else
            {
                Console.WriteLine("O ano não é um ano bissexto (tem 365 dias)");
            }
        }
    }
}
