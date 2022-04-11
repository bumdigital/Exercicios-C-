using System;

namespace Exercicio075
{
    //75) Desenvolva um programa que leia quatro valores
    //pelo teclado e guarde-os em uma tupla. No final, mostre:

    //A) Quantas vezes apareceu o valor 9.
    //B) Em que posição foi digitado o primeiro valor 3.
    //C) Quais foram os números pares.

    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            int contador9 = 0;
            int contadorPares = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 9)
                {
                    contador9++;
                }
            }
            if (contador9 > 0)
            {
                Console.WriteLine($"A quantidade de numeros 9 digitadoe é {contador9}");
            } else
            {
                Console.WriteLine("O numero 9 não foi digitado");
            }
            int valor3 = Array.IndexOf(numeros, 3);
            if (valor3 != -1)
            {
                Console.WriteLine($"O numero 3 está na posição {valor3+1} do vetor");
            } else
            {
                Console.WriteLine("O numero 3 não foi digitado");
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0 && contadorPares == 0)
                {
                    contadorPares++;
                    Console.Write($"Os numeros pares são {numeros[i]}");
                } else if (numeros[i] % 2 == 0 && contadorPares != 0)
                {
                    Console.Write($", {numeros[i]}");
                }
            }
            if (contadorPares == 0)
            {
                Console.WriteLine("Não foram digitados numeros pares");
            }
        }
    }
}
