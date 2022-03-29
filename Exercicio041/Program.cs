using System;

namespace Exercicio041
{
    //41) A Confederação Nacional de Natação precisa
    //de um programa que leia o ano de nascimento de
    //um atleta e mostre sua categoria, de acordo
    //com a idade:
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o ano de nascimento do atleta: ");
            int anoNascimento = int.Parse(Console.ReadLine());
            int anoAtual = DateTime.Now.Year;
            int idade = anoAtual - anoNascimento;
            if (idade <= 5)
            {
                Console.WriteLine("Categoria mirim");
            } else if (idade <= 12)
            {
                Console.WriteLine("Categoria junior");
            } else if (idade <= 18)
            {
                Console.WriteLine("Categoria jovem");
            } else if (idade <= 25)
            {
                Console.WriteLine("Categoria jovem+");
            } else if (idade <= 35)
            {
                Console.WriteLine("Categoria experiente");
            } else if (idade <= 45)
            {
                Console.WriteLine("Categoria experiente+");
            } else
            {
                Console.WriteLine("Categoria ancião");
            }
        }
    }
}
