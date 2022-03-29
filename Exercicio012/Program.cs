using System;

namespace Exercicio012
{
    //12) Faça um algoritmo que leia o preço
    //de um produto e mostre seu novo preço,
    //com 5% de desconto.
    class Program
    {
        static void Main(string[] args)
        {
            float preco;
            Console.Write("Digite o preço: R$");
            preco = float.Parse(Console.ReadLine());
            float desconto = (preco / 100) * 5;
            preco -= desconto;
            Console.WriteLine($"O produto com 5% de desconto agora custa R${preco:f2}");
        }
    }
}
