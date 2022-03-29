using System;

namespace Exercicio031
{
    //31) Desenvolva um programa que pergunte a distância
    //de uma viagem em Km. Calcule o preço da passagem,
    //cobrando R$0,50 por Km para viagens de até 200Km e
    //R$0,45 parta viagens mais longas.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de kms para a viagem: ");
            float kms = float.Parse(Console.ReadLine());
            float valor1 = 0.50f;
            float valor2 = 0.45f;
            float total;
            if (kms <= 200)
            {
                total = kms * valor1;
            }
            else
            {
                total = kms * valor2;
            }
            Console.WriteLine($"O valor total a ser pago é R${total:f2}");
        }
    }
}
