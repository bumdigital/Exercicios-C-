using System;

namespace Exercicio016
{
    //16) Crie um programa que leia um número Real
    //qualquer pelo teclado e mostre na tela a sua
    //porção Inteira.
    class Program
    {
        static void Main(string[] args)
        {
            float n1;
            Console.Write("Digite um numero real: ");
            n1 = float.Parse(Console.ReadLine());
            int inteiro = (int)Math.Truncate(n1);
            Console.WriteLine($"A porção inteira de {n1} é {inteiro}");
        }
    }
}
