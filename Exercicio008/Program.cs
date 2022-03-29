using System;

namespace Exercicio008
{
    //8) Escreva um programa que leia um valor
    //em metros e o exiba convertido em
    //centímetros e milímetros.
    class Program
    {
        static void Main(string[] args)
        {
            float n1;
            float centimetros;
            float milimetros;
            Console.Write("Digite a quantidade de metros: ");
            n1 = float.Parse(Console.ReadLine());
            centimetros = n1 * 100;
            milimetros = centimetros * 100;
            Console.WriteLine($"{n1} metros " +
                $"\n Convertido em centimetros {centimetros} " +
                $"\n Convertido em milimetros {milimetros}");
        }
    }
}
