using System;

namespace Exercicio071
{
    //71) Crie um programa que simule o funcionamento de
    //um caixa eletrônico. No início, pergunte ao usuário
    //qual será o valor a ser sacado (número inteiro) e o
    //programa vai informar quantas cédulas de cada valor
    //serão entregues.
    //OBS: considere que o caixa possui cédulas de R$50, R$20, R$10 e R$1.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor que deseja sacar R$");
            int valor = int.Parse(Console.ReadLine());
            int cinquenta = 0;
            int vinte = 0;
            int dez = 0;
            int um = 0;
            while (valor > 0)
            {
                if (valor - 50 >= 0)
                {
                    valor -= 50;
                    cinquenta += 1;
                } else if (valor - 20 >= 0)
                {
                    valor -= 20;
                    vinte += 1;
                } else if (valor - 10 >= 0)
                {
                    valor -= 10;
                    dez += 1;
                } else if (valor - 1 >= 0)
                {
                    valor -= 1;
                    um += 1;
                }
            }
            if (cinquenta > 0)
            {
                Console.WriteLine($"{cinquenta} notas de 50");
            }
            if (vinte > 0)
            {
                Console.WriteLine($"{vinte} notas de 20");
            }
            if (dez > 0)
            {
                Console.WriteLine($"{dez} notas de 10");
            }
            if (um > 0)
            {
                Console.WriteLine($"{um} notas de 1");
            }      
        }
    }
}
