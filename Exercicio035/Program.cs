using System;

namespace Exercicio035
{
    //35) Desenvolva um programa que leia o comprimento
    //de três retas e diga ao usuário se elas podem ou
    //não formar um triângulo.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o lado A do triangulo: ");
            float ladoA = float.Parse(Console.ReadLine());
            Console.Write("Digite o lado B do triangulo: ");
            float ladoB = float.Parse(Console.ReadLine());
            Console.Write("Digite o lado C do triangulo: ");
            float ladoC = float.Parse(Console.ReadLine());
            if (ladoA >= ladoB + ladoC || ladoB >= ladoA + ladoC || ladoC >= ladoA + ladoB)
            {
                Console.WriteLine("Não é possivel formar um triangulo");
            } else
            {
                Console.WriteLine("É possivel formar um triangulo");
            }

        }
    }
}
