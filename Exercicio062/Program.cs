using System;
using System.Threading;

namespace Exercicio062
{
    //62) Melhore o DESAFIO 061, perguntando para o
    //usuário se ele quer mostrar mais alguns termos.
    //O programa encerrará quando ele disser que quer
    //mostrar 0 termos.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro termo da PA: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite a razão da PA: ");
            int razao = int.Parse(Console.ReadLine());
            int contador = 10;
            while (contador != 0)
            {
                for (int i = 1; i <= contador; i++)
                {
                    Console.WriteLine($"{numero}");
                    numero += razao;
                    Thread.Sleep(150);
                }
                Console.Write("Quer ver mais termos? Digite a quantidade de termos " +
                    "que deseja ver: ");
                contador = int.Parse(Console.ReadLine());
            }
        }
    }
}
