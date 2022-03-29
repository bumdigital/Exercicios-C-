using System;

namespace Exercicio030
{
    //30) Crie um programa que leia um número
    //inteiro e mostre na tela se ele é PAR ou ÍMPAR.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 != 0)
            {
                Console.WriteLine($"O numero {numero} é IMPAR");
            } else
            {
                Console.WriteLine($"O numero {numero} é PAR");
            }
        }
    }
}
