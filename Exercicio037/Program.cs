using System;

namespace Exercicio037
{
    //37) Escreva um programa em Python que leia um
    //número inteiro qualquer e peça para o usuário
    //escolher qual será a base de conversão: 1 para
    //binário, 2 para octal e 3 para hexadecimal.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Base de conversão: \n1 para" +
                " binário, \n2 para octal, \n3 para hexadecimal.\n" +
                "Escolha uma das opções: ");
            int baseN = int.Parse(Console.ReadLine());
            string numeroString = numero.ToString("X");
            if (baseN == 1)
            {
                var intEmhex = numeroString;
                Console.WriteLine($"O equivalente do numero {numero} em hexadecimal é {intEmhex}");
            } else if (baseN == 2)
            {
                var intEmOcta = Convert.ToString(numero, 8);
                Console.WriteLine($"O equivalente do numero {numero} em octal é {intEmOcta}");
            } else if (baseN == 3)
            {
                var intEmBinari = Convert.ToString(numero, 2);
                Console.WriteLine($"O equivalente do numero {numero} em octal é {intEmBinari}");

            } else
            {
                Console.WriteLine("Opção inválida!");
            }

        }
    }
}
