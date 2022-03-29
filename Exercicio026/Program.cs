using System;
using System.Text.RegularExpressions;

namespace Exercicio026
{
    //26) Faça um programa que leia uma frase pelo
    //teclado e mostre quantas vezes aparece a
    //letra "A", em que posição ela aparece a
    //primeira vez e em que posição ela aparece a última vez.
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCICIO ALTERNATIVO AO ENUNCIADO (UTILIZANDO MatchCollection)
            //###############################################################
            /*Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine().ToUpper();
            string letraA = "A";
            MatchCollection matches = Regex.Matches(frase, letraA);
            foreach (Match item in matches)
            {
                Console.WriteLine($"{letraA} {item.Index}");
            }*/

            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine().ToUpper();
            string letraA = "A";
            int contador = 0;
            for (int i = 0; i<frase.Length; i++)
            {
                if (frase[i].ToString() == letraA)
                {
                    contador += 1;
                }
            }
            Console.WriteLine($"A letra A se repete {contador} vezes da frase");
            Console.WriteLine($"A primeira vez que a letra A aparece é na posição {frase.IndexOf(letraA)}");
            Console.WriteLine($"A ultima vez que a letra A aparece é na posição {frase.LastIndexOf(letraA)}");
        }
    }
}
