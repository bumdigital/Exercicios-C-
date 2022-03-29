using System;

namespace Exercicio025
{
    //25) Crie um programa que leia o nome
    //de uma pessoa e diga se ela tem "SILVA" no nome.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome completo: ");
            string nome = Console.ReadLine().ToUpper();
            string silva = "SILVA"; 
            if (nome.Contains(silva))
            {
                Console.WriteLine(true);
            } else
            {
                Console.WriteLine(false);
            }
        }
    }
}
