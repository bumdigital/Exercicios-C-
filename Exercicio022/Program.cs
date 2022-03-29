using System;

namespace Exercicio022
{
 //22) Crie um programa que leia o nome completo de uma pessoa e mostre: 
 //O nome com todas as letras maiúsculas e minúsculas.
 //Quantas letras ao todo (sem considerar espaços).
 //Quantas letras tem o primeiro nome.

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome completo: ");
            var nome = Console.ReadLine();
            Console.WriteLine(nome.ToUpper());
            Console.WriteLine(nome.ToLower());
            int contador = 0, espacos = 0;
            for (int i = 0; i < nome.Length; i++)
            {
                string nomeString = nome[i].ToString();
                if (nomeString == " ")
                {
                    espacos += 1;
                    contador = nome.Length - espacos;
                }
            }
            Console.WriteLine($"Seu nome tem {contador} letras");
            var encontre = nome.IndexOf(" ");
            Console.WriteLine($"Seu primeiro nome tem {encontre} letras");           
        }
    }
}
