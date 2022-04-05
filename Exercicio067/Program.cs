using System;

namespace Exercicio067
{
    //67) Faça um programa que mostre a tabuada de vários
    //números, um de cada vez, para cada valor digitado
    //pelo usuário. O programa será interrompido quando
    //o número solicitado for negativo. 
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Digite um numero para ver sua tabuada: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero < 0)
                {
                    break;
                }
                for (int i = 1; i <= 10; i++)
                {
                    int mult = numero * i;
                    Console.WriteLine($"{numero} X {i} = {mult}");
                }
            }
        }
    }
}
