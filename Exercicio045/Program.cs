using System;

namespace Exercicio045
{
    //45) Crie um programa que faça o computador jogar Jokenpô com você.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("PREDRA  [ 1 ]\n" +
                "PAPEL   [ 2 ]\n" +
                "TESOURA [ 3 ]\n" +
                "Escolha: ");
            int jogador = int.Parse(Console.ReadLine());
            Random random = new Random();
            int computador = random.Next(1,3);
            if (computador == 1)
            {
                if (jogador == 2)
                {
                    Console.WriteLine($"Você GANHOU. Você jogou {jogador} " +
                    $"e o computador jogou {computador}");
                } else if (jogador == 3)
                {
                    Console.WriteLine($"Você PERDEU. Você jogou {jogador} " +
                    $"e o computador jogou {computador}");
                }
                
            } else if (computador == 2)
            {
                if (jogador == 1)
                {
                    Console.WriteLine($"Você PERDEU. Você jogou {jogador} " +
                    $"e o computador jogou {computador}");
                }
                else if (jogador == 3)
                {
                    Console.WriteLine($"Você GANHOU. Você jogou {jogador} " +
                    $"e o computador jogou {computador}");
                }

            } else if (computador == 3)
            {
                if (jogador == 1)
                {
                    Console.WriteLine($"Você GANHOU. Você jogou {jogador} " +
                    $"e o computador jogou {computador}");
                }
                else if (jogador == 2)
                {
                    Console.WriteLine($"Você PERDEU. Você jogou {jogador} " +
                    $"e o computador jogou {computador}");
                }

            } else if (computador == jogador)
            {
                Console.WriteLine($"Houve empate. Você jogou {jogador} " +
                    $"e o computador jogou {computador}");
            } else if (jogador == 1)
            {
                if (computador == 2)
                {
                    Console.WriteLine($"Você PERDEU. Você jogou {jogador} " +
                    $"e o computador jogou {computador}");
                } else if (computador == 3)
                {
                    Console.WriteLine($"Você GANHOU. Você jogou {jogador} " +
                    $"e o computador jogou {computador}");
                }

            } else if (jogador == 2)
            {
                if (computador == 1)
                {
                    Console.WriteLine($"Você GANHOU. Você jogou {jogador} " +
                    $"e o computador jogou {computador}");
                }
                else if (computador == 3)
                {
                    Console.WriteLine($"Você PERDEU. Você jogou {jogador} " +
                    $"e o computador jogou {computador}");
                }

            } else if (jogador == 3)
            {
                if (computador == 1)
                {
                    Console.WriteLine($"Você PERDEU. Você jogou {jogador} " +
                    $"e o computador jogou {computador}");
                }
                else if (computador == 2)
                {
                    Console.WriteLine($"Você GANHOU. Você jogou {jogador} " +
                    $"e o computador jogou {computador}");
                }
            }
        }
    }
}
