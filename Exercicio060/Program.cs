using System;

namespace Exercicio060
{
    //60) Faça um programa que leia um número
    //qualquer e mostre o seu fatorial.
    //Ex: 5! = 5 x 4 x 3 x 2 x 1 = 120
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());
            int fatorial = 1;
            Console.Write($"{numero}! ");
            for (int i = numero; i > 0; i--)
            {
                fatorial *= i;
                string sinal = i > 1 ? "x" : " = ";
                Console.Write($"{i}{sinal}");
            }
            Console.WriteLine($"{fatorial}");
        }
    }
}
