using System;

namespace Exercicio066
{
    //66) Crie um programa que leia números inteiros
    //pelo teclado. O programa só vai parar quando o
    //usuário digitar o valor 999, que é a condição
    //de parada. No final, mostre quantos números
    //foram digitados e qual foi a soma entre elas
    //(desconsiderando o flag).
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int acumulador = 0;
            while (true)
            {
                Console.Write("Digite um numero ou para parar digite 999: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero == 999)
                {
                    break;
                }
                contador += 1;
                acumulador += numero;
            }
            Console.WriteLine($"A quantidade de numeros digitados é {contador}" +
                $" e a soma deles é {acumulador}");
        }
    }
}
