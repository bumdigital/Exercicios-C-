using System;

namespace Exercicio063
{
    //63) Escreva um programa que leia um número N
    //inteiro qualquer e mostre na tela os N primeiros
    //elementos de uma Sequência de Fibonacci. 

    //Ex: 0 - 1 - 1 - 2 - 3 - 5 - 8
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de elementos da sequência: ");
            int elementos = int.Parse(Console.ReadLine());
            int n1 = 0;
            int n2 = 1;
            int n3 = 0;
            if (elementos >= 1)
            {
                Console.Write($"{n1} ");
            } 
            if (elementos >= 2)
            {
                Console.Write($"{n2} ");
            }      
            for (int i = 3; i <= elementos; i++)
            {
                n3 = n2 + n1;
                Console.Write($"{n3} ");
                n1 = n2;
                n2 = n3;             
            }
        }
    }
}
