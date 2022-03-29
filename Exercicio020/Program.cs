using System;
using System.Linq;

namespace Exercicio020
{
    //20) O mesmo professor do desafio 019 quer
    //sortear a ordem de apresentação de trabalhos
    //dos alunos.Faça um programa que leia o nome dos
    //quatro alunos e mostre a ordem sorteada.
    class Program
    {
        static void Main(string[] args)
        {
            string[] aluno = new string[4];
            for (int i = 0; i < aluno.Length; i++)
            {
                Console.Write($"Digite o nome do aluno {i + 1}: ");
                aluno[i] = Console.ReadLine();
            }
            Random random = new Random();
            var embaralhandoArray = aluno.OrderBy(x => random.Next()).ToArray();
            Console.WriteLine("A ordem sorteada dos alunos é:");
            for (int i = 0; i < embaralhandoArray.Length; i++) 
            {
                Console.WriteLine($"Aluno(a) {embaralhandoArray[i]}");
            }
        }
    }
}
