using System;

namespace Exercicio028
{
    //28) Escreva um programa que faça o computador
    //"pensar" em um número inteiro entre 0 e 5 e
    //peça para o usuário tentar descobrir qual
    //foi o número escolhido pelo computador.
    //O programa deverá escrever na tela se o
    //usuário venceu ou perdeu.
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int computador = random.Next(0,5);
            Console.Write("Tente adivilhar o numero de 0 a 5 em que o computador pensou: ");
            int jogador = int.Parse(Console.ReadLine());
            if (computador == jogador)
            {
                Console.WriteLine($"Parabéns! Você acertou. O " +
                    $"computador pensou em {computador} e você acertou!");
            } else
            {
                Console.WriteLine($"Não foi dessa vez. O computador pensou em " +
                    $"{computador} e você escolheu {jogador}");
            }
        }
    }
}
