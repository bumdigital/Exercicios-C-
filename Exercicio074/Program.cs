using System;

namespace Exercicio074
{
    //74) Crie um programa que vai gerar cinco números
    //aleatórios e colocar em uma tupla. Depois disso,
    //mostre a listagem de números gerados e também indique
    //o menor e o maior valor que estão na tupla.
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int maior = 0;
            int menor = 0;
            for (int i = 0; i < 5; i++)
            {
                Random random = new Random();
                int sorteio = random.Next(0,100);
                numeros[i] = sorteio;
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
                if (i == 0)
                {
                    maior = numeros[i];
                    menor = numeros[i];
                } else if (numeros[i] > maior )
                {
                    maior = numeros[i];
                } else if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }
            Console.WriteLine("################################");
            Console.WriteLine($"O maior numero é {maior}");
            Console.WriteLine($"O menor numero é {menor}");
        }
    }
}
