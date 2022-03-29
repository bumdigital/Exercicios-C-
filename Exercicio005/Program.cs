using System;

namespace Exercicio005
{
    //5) Faça um programa que leia um número Inteiro
    //e mostre na tela o seu sucessor e seu antecessor.
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int ant;
            int suc;
            Console.Write("Digite um numero: ");
            n1 = int.Parse(Console.ReadLine());
            ant = n1 - 1;
            suc = n1 + 1;
            Console.WriteLine($"O antecessor de {n1} é {ant} e o sucessor é {suc}");
        }
    }
}
