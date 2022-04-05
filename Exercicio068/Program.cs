using System;

namespace Exercicio068
{
    //68) Faça um programa que jogue par ou ímpar
    //com o computador. O jogo só será interrompido
    //quando o jogador perder, mostrando o total de
    //vitórias consecutivas que ele conquistou no
    //final do jogo. 
    class Program
    {
        static void Main(string[] args)
        {
            string escolha = "";
            string computador2 = "";
            int contador = 0;
            int computador = 0;
            int jogador = 0;
            bool resultado = false;
            while (resultado == false)
            {
                Console.Write("Escolha Par ou Impar [P/I]: ");
                escolha = Console.ReadLine().ToUpper();
                while (escolha != "P" && escolha != "I")
                {
                    Console.Write("VALOR INCORRETO! Digite P para ou I para impar [P/I]: ");
                    escolha = Console.ReadLine().ToUpper();
                }
                Random random = new Random();
                if(escolha == "I")
                {
                    computador2 = "P";
                } else
                {
                    computador2 = "I";
                }
                computador = random.Next(0, 10);
                Console.Write("Digite um numero para jogar: ");
                jogador = int.Parse(Console.ReadLine());
                if ((computador + jogador) % 2 == 0 && computador2 == "P")
                {
                    resultado = false;
                    contador += 1;
                } else if ((computador + jogador) % 2 != 0 && computador2 == "I")
                {
                    resultado = false;
                    contador += 1;
                } else
                {
                    resultado = true;
                }
                Console.WriteLine("####################################");
                Console.WriteLine($"VOCÊ PERDEU! Você escolheu {escolha} " +
                    $"e o computador escolheu {computador2}.\n" +
                    $"Os valores da jogada são computador {computador} e você {jogador}");
            }
            Console.WriteLine("####################################");
            Console.WriteLine($"VOCÊ VENCEU! Você escolheu {escolha} " +
                $"e o computador escolheu {computador2}.\n" +
                $"A quantidade de vitorias do computador é {contador}.\n" +
                $"Os valores da jogada são computador {computador} e você {jogador}");
        }
    }
}
