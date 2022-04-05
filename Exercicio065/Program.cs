using System;

namespace Exercicio065
{
    //65) Crie um programa que leia vários números inteiros
    //pelo teclado. No final da execução, mostre a média
    //entre todos os valores e qual foi o maior e o menor
    //valores lidos. O programa deve perguntar ao usuário
    //se ele quer ou não continuar a digitar valores.
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            float maior = 0;
            float menor = 0;
            float acumulador = 0;
            float media = 0;
            float numero = 0;
            string continuar = "";
            while (continuar != "N")
            {
                Console.Write("Digite um numero: ");
                numero = float.Parse(Console.ReadLine());
                Console.Write("Deseja continuar? [S/N]: ");
                continuar = Console.ReadLine().ToUpper();
                contador++;
                acumulador += numero;
                media = acumulador / contador;
                if (contador == 1)
                {
                    maior = numero;
                    menor = numero;
                }
                else
                {
                    if (numero > maior)
                    {
                        maior = numero;
                    }
                    if (menor > numero)
                    {
                        menor = numero;
                    }
                }               
            }
            Console.Write($"A media dos numeros digitados é {media:f2}" +
                $"\nO maior numero digitado é {maior:f2}" +
                $"\nO menor numero digitado é {menor:f2}");
        }
    }
}
