using System;

namespace Exercicio003
{
    //3) Crie um programa que leia dois números e mostre a soma entre eles.
    class Program
    {
        static void Main(string[] args)
        {
            float n1;
            float n2;
            float soma;
            Console.Write("Digite um numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro numero: ");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine($"A soma de {n1} e {n2} é {soma}");

        }
    }
}
