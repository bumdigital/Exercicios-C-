using System;
using System.Collections.Generic;

namespace Exercicio019
{
    //19) Um professor quer sortear um dos seus quatro
    //alunos para apagar o quadro. Faça um programa que
    //ajude ele, lendo o nome dos alunos e escrevendo
    //na tela o nome do escolhido.
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
            Random numeroSort = new Random();
            var sorteado = numeroSort.Next(0, aluno.Length);
            Console.WriteLine($"O aluno(a) escolhido para apagar o quadro é {aluno[sorteado]}");
        }
    }
}
