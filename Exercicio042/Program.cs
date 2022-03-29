using System;

namespace Exercicio042
{
    //42) Refaça o DESAFIO 035 dos triângulos,
    //acrescentando o recurso de mostrar que
    //tipo de triângulo será formado:
    //- EQUILÁTERO: todos os lados iguais
    //- ISÓSCELES: dois lados iguais, um diferente
    //- ESCALENO: todos os lados diferentes
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho do lado 1: ");
            float lado1 = float.Parse(Console.ReadLine());
            Console.Write("Digite o tamanho do lado 2: ");
            float lado2 = float.Parse(Console.ReadLine());
            Console.Write("Digite o tamanho do lado 3: ");
            float lado3 = float.Parse(Console.ReadLine());
            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("EQUILÁTERO: todos os lados iguais");
                } else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
                {
                    Console.WriteLine("ISÓSCELES: dois lados iguais, um diferente");
                } else
                {
                    Console.WriteLine("ESCALENO: todos os lados diferentes");
                }
            } else
            {
                Console.WriteLine("Não é possivel formar um trinangulo com os " +
                    "vlores fornecidos");
            }
        }
    }
}
