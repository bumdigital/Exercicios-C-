using System;

namespace Exercicio039
{
    //39) Faça um programa que leia o ano de nascimento
    //de um jovem e informe, de acordo com a sua idade,
    //se ele ainda vai se alistar ao serviço militar,
    //se é a hora exata de se alistar ou se já passou
    //do tempo do alistamento. Seu programa também
    //deverá mostrar o tempo que falta ou que passou do prazo.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());
            int anoTual = DateTime.Now.Year;
            int idade = anoTual - anoNascimento;
            if (idade == 18)
            {
                Console.WriteLine("É a hora exata de se alistar");
            } else if (idade < 18)
            {
                var faltamAnos = 18 - idade;
                Console.WriteLine($"Faltam {faltamAnos} para você se alistar");
            } else
            {
                var anosAtrasado = idade - 18;
                Console.WriteLine($"Você está {anosAtrasado} anos atrasado para se alistar");
            }
        }
    }
}
