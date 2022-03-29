using System;

namespace Exercicio007
{
    //7) Desenvolva um programa que leia as duas
    //notas de um aluno, calcule e mostre a sua média.
    class Program
    {
        static void Main(string[] args)
        {
            float n1;
            float n2;
            float media;
            Console.Write("Digite a primeira nota: ");
            n1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            n2 = float.Parse(Console.ReadLine());
            media = (n1 + n2) / 2;
            Console.WriteLine($"A média final é {media}");
        }
    }
}
