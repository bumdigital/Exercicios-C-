using System;

namespace Exercicio024
{
    //24) Crie um programa que leia o nome de uma
    //cidade diga se ela começa ou não com o nome "SANTO".
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome de uma cidade: ");
            string cidade = Console.ReadLine().ToUpper();
            string santo = "SANTO";
            int contador = 0;
            for (int i = 0; i < 5; i++)
            {
                if (cidade[i] == santo[i])
                {
                    contador += 1;
                }
            }
            if (contador == 5)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
