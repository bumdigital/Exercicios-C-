using System;

namespace Exercicio010
{
    //10)  Crie um programa que leia quanto
    //dinheiro uma pessoa tem na carteira e
    //mostre quantos dólares ela pode comprar.
    class Program
    {
        static void Main(string[] args)
        {
            float n1;
            float dolar;
            Console.Write("Digite a quantidade em reais: R$");
            n1 = float.Parse(Console.ReadLine());
            dolar = (float)(n1 / 5.08);
            Console.WriteLine($"Com R${n1:f2} é possivel comprar ${dolar:f2}");
        }
    }
}
