using System;

namespace Exercicio064
{
    //64) Crie um programa que leia vários números inteiros
    //pelo teclado. O programa só vai parar quando o usuário
    //digitar o valor 999, que é a condição de parada. No final,
    //mostre quantos números foram digitados e qual foi a soma
    //entre eles (desconsiderando o flag).
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int contador = 0;
            int acumulador = 0;
            Console.Write("Digite 999 para encerras e qualquer " +
                "outro numero para continuar: ");
            numero = int.Parse(Console.ReadLine());
            while (numero != 999)
            {               
                acumulador += numero;
                contador++;
                Console.Write("Digite 999 para encerras e qualquer " +
                "outro numero para continuar: ");
                numero = int.Parse(Console.ReadLine()); 
            }
            Console.WriteLine($"A quantidade de numeros digitados é {contador}" +
                $" e a soma dos numeros é {acumulador}");
        }
    }
}
