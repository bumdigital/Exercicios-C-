using System;

namespace Exercicio029
{
    //29) Escreva um programa que leia a velocidade
    //de um carro. Se ele ultrapassar 80Km/h, mostre
    //uma mensagem dizendo que ele foi multado.
    //A multa vai custar R$7,00 por cada Km acima do limite.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de Kms percorridos: ");
            float kms = float.Parse(Console.ReadLine());
            float excedente = kms - 80;
            float multa = excedente * 7;
            if (kms > 80)
            {
                Console.WriteLine($"Você excedeu {excedente} Kms do limete." +
                    $" A multa a ser paga é de R${multa:f2}");
            } else
            {
                Console.WriteLine("Dentro do limite de velocidade permitido.");
            }
        }
    }
}
