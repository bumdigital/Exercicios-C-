using System;
using System.Threading;

namespace Exercicio061
{
    //61) Refaça o DESAFIO 051, lendo o primeiro termo e a
    //razão de uma PA, mostrando os 10 primeiros termos da
    //progressão usando a estrutura while.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro termo da PA: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite a razão da PA: ");
            int razao = int.Parse(Console.ReadLine());
            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine($"{numero}");
                contador++;
                numero += razao;                
                Thread.Sleep(150);
            }
        }
    }
}
