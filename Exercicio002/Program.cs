using System;

namespace Exercicio002
{
    //2) Faça um programa que leia o nome de uma pessoa e mostre
    //uma mensagem de boas-vindas.
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}!");
        }
    }
}
