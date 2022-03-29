using System;

namespace Exercicio023
{
    //23) Faça um programa que leia um número de 0 a 9999 e
    //mostre na tela cada um dos dígitos separados.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero de 0 a 9999: ");
            int numero = int.Parse(Console.ReadLine());
            if (!(numero >= 0) || !(numero <= 9999) )
            {
                Console.WriteLine("Valor fora do intervalo de 0 a 9999");
            } else
            {
                string stringNumero = numero.ToString();
                for (int i = 0; i< stringNumero.Length; i++)
                {
                    Console.WriteLine($"Digito {i + 1}: {stringNumero[i]}");
                }
            }
        }
    }
}
