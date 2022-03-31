using System;

namespace Exercicio053
{
    //53) Crie um programa que leia uma frase qualquer
    //e diga se ela é um palíndromo, desconsiderando
    //os espaços.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um frase: ");
            string frase = Console.ReadLine().ToLower();
            char[] arr = frase.ToCharArray();
            string juntando = string.Join("",arr);
            string semEspacos = juntando.Replace(" ", "");
            char[] arr2 = semEspacos.ToCharArray();
            Array.Reverse(arr2);
            string invertido = string.Join("",arr2);
            if (semEspacos == invertido)
            {
                Console.WriteLine("A frase É um palindromo\n" +
                    $"{semEspacos}\n" +
                    $"{invertido}");
            }
            else
            {
                Console.WriteLine("A frase NÂO É um palindromo\n" +
                    $"{semEspacos}\n" +
                    $"{invertido}");
            }
        }
    }
}
