using System;

namespace Exercicio014
{
    //14) Escreva um programa que converta uma
    //temperatura digitando em graus Celsius
    //e converta para graus Fahrenheit.
    class Program
    {
        static void Main(string[] args)
        {
            float celsius;
            Console.Write("Digite a quantidade de graus celsius: ");
            celsius = float.Parse(Console.ReadLine());
            float fahrenheit = (float)(celsius * 1.8 + 32);
            Console.WriteLine($"{celsius} graus Celsius são {fahrenheit} graus Fahrenheit");
        }
    }
}
