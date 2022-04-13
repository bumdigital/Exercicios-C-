using System;

namespace Exercicio077
{
    //77) Crie um programa que tenha uma tupla com várias
    //palavras (não usar acentos). Depois disso, você deve
    //mostrar, para cada palavra, quais são as suas vogais.
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = {"xaxula", "preula", "prexela", "paracatu"};
            for (int i = 0; i < palavras.Length; i++)
            {
                Console.Write($"A palavra {palavras[i]} tem as vogais");
                for(int j = 0; j < palavras[i].Length; j++)
                {
                    string palavra = palavras[i];
                    string letra = palavra[j].ToString();
                    if (letra == "a" || letra == "e" || letra == "i" || letra == "o" ||
                        letra == "u")
                    {
                        Console.Write($" {letra}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
