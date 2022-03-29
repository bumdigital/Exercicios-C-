using System;

namespace Exercicio038
{
    //38) Escreva um programa que leia dois números
    //inteiros e compare-os. mostrando na tela
    //uma mensagem:
    //- O primeiro valor é maior
    //- O segundo valor é maior
    //- Não existe valor maior, os dois são iguais

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine($"O promeiro numero é maior");
            } else if (n2 > n1)
            {
                Console.WriteLine($"O segundo numero é maior");
            } else
            {
                Console.WriteLine("Não existe valor maior, os dois são iguais");
            }
        }
    }
}
