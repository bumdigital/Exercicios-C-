using System;

namespace Exercicio006
{
    //6) Crie um algoritmo que leia um número e
    //mostre o seu dobro, triplo e raiz quadrada.
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int dobro;
            int triplo;
            int raiz;
            Console.Write("Digite um numero: ");
            n1 = int.Parse(Console.ReadLine());
            dobro = n1 * 2;
            triplo = n1 * 3;
            Console.WriteLine($"O dobro de {n1} é {dobro}");
            Console.WriteLine($"O triplo de {n1} é {triplo}");
            int i = 0;
            while ((i * i) < n1)
            {
                i += 1; 
                if ((i * i) == n1)
                {
                    raiz = i;
                    Console.WriteLine($"A raiz quadrada de {n1} é {raiz}");
                } else if ((i * i) > n1)
                {
                    Console.WriteLine($"O numero {n1} não tem raiz quadrada");
                }
            }

        }
    }
}
