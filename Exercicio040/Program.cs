using System;

namespace Exercicio040
{
    //40) Crie um programa que leia duas notas de um
    //aluno e calcule sua média, mostrando uma mensagem
    //no final, de acordo com a média atingida:
    //- Média abaixo de 5.0: REPROVADO
    //- Média entre 5.0 e 6.9: RECUPERAÇÃO
    //- Média 7.0 ou superior: APROVADO

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a primeira nota: ");
            float nota1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());
            float media = (nota1 + nota2) / 2;
            if (media < 5)
            {
                Console.WriteLine("REPROVADO");
            } else if (media >= 5 && media <= 6.9)
            {
                Console.WriteLine("RECUPERAÇÃO");
            } else if (media >= 7 && media <= 10)
            {
                Console.WriteLine("APROVADO");
            } else
            {
                Console.WriteLine("Valores inválidos");
            }

        }
    }
}
