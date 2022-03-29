using System;

namespace Exercicio049_
{
    //49) Refaça o DESAFIO 009, mostrando a tabuada
    //de um número que o usuário escolher, só que
    //agora utilizando um laço for.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero cujo quera ver sua tabiada: ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}
