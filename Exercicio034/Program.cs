using System;

namespace Exercicio034
{
    //34) Escreva um programa que pergunte o salário
    //de um funcionário e calcule o valor do seu
    //aumento. Para salários superiores a R$1250,00,
    //calcule um aumento de 10%. Para os inferiores
    //ou iguais, o aumento é de 15%.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu salario: R$");
            float salario = float.Parse(Console.ReadLine());
            int percentual = 0;
            if (salario > 1250)
            {
                salario += (salario / 100) * 10;
                percentual = 10;
            } else
            {
                salario += (salario / 100) * 15;
                percentual = 15;
            }
            Console.WriteLine($"Seu salario passa a ser {salario:f2} com {percentual}%" +
                $" de aumento.");
        }
    }
}
