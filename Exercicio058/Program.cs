using System;

namespace Exercicio058
{
    //58)  Melhore o jogo do DESAFIO 028 onde o computador vai
    //"pensar" em um número entre 0 e 10. Só que agora o jogador
    //vai tentar adivinhar até acertar, mostrando no final
    //quantos palpites foram necessários para vencer.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero de 0 a 10: ");
            int jogador = int.Parse(Console.ReadLine());
            Random random = new Random();
            int computador = random.Next(0,10);
            int contador = 1;
            while (jogador != computador)
            {
                contador += 1;
                Console.Write("Você errou! " +
                    $"Tente novamente: ");
                jogador = int.Parse(Console.ReadLine());
            }          
            if (jogador == computador)
            {
                Console.WriteLine("Parabéns! Você acertou!\n" +
                    $"Você escolheu {jogador} e o computador {computador}\n" +
                    $"Você preciou de {contador} palpites pra acertar");
            }
        }
    }
}
