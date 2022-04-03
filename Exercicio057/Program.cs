using System;

namespace Exercicio057
{
    //57) Faça um programa que leia o sexo de uma pessoa,
    //mas só aceite os valores 'M' ou 'F'. Caso esteja
    //errado, peça a digitação novamente até ter um valor correto.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite M para masculido e F para feminino: ");
            string sexo = Console.ReadLine();
            while (sexo != "M" && sexo != "F")
            {
                Console.Write("Valor inválido. Digite novamante: ");
                sexo = Console.ReadLine();
            }      
        }
    }
}
