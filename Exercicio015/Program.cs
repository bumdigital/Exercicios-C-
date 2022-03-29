using System;

namespace Exercicio015
{
    //15) Escreva um programa que pergunte a
    //quantidade de Km percorridos por um carro
    //alugado e a quantidade de dias pelos quais
    //ele foi alugado.Calcule o preço a pagar,
    //sabendo que o carro custa R$60 por dia e
    //R$0,15 por Km rodado.
    class Program
    {
        static void Main(string[] args)
        {
            float kilometros;
            int dias;
            Console.Write("Digite a quantidade de Kilometros percorrido: ");
            kilometros = float.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de dias de locação do carro: ");
            dias = int.Parse(Console.ReadLine());
            float preco = (float)(kilometros * 0.5 + dias * 60);
            Console.WriteLine($"O preço total é R${preco}");
        }
    }
}
