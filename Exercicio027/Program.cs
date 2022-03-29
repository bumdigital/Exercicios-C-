using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio027
{
    //27) Faça um programa que leia o nome completo
    //de uma pessoa, mostrando em seguida o
    //primeiro e o último nome separadamente.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome completo: ");
            string nome = Console.ReadLine();
            List<string> primeiro = new List<string>();
            List<string> ultimo = new List<string>();
            for (int i = 0; i < nome.Length; i++)
            {
                if (nome[i].ToString() != " ")
                {
                    primeiro.Add(nome[i].ToString());
                } else
                {
                    break;
                }
            }
            string invertido = new string(nome.Reverse().ToArray());
            for (int i = 0; i < invertido.Length; i++)
            {
                if (invertido[i].ToString() != " ")
                {
                    ultimo.Add(invertido[i].ToString());
                } else
                {
                    break;
                }
            }
            ultimo.Reverse();
            var primeiro1 = string.Join("", primeiro);
            var ultimo1 = string.Join("", ultimo);
            Console.WriteLine($"{primeiro1} {ultimo1}");
        }
    }
}
