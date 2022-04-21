using System;
using System.Collections.Generic;

namespace Exercicio084
{
    //84) Faça um programa que leia nome e peso de várias
    //pessoas, guardando tudo em uma lista. No final, mostre:
    //A) Quantas pessoas foram cadastradas.
    //B) Uma listagem com as pessoas mais pesadas.
    //C) Uma listagem com as pessoas mais leves.

    class Program
    {
        static void Main(string[] args)
        {
            List<List<dynamic>> cadastro = new List<List<dynamic>>();
            List<dynamic> cadastroEstruturado = new List<dynamic>();
            string continuar = "S";
            int contador = 0;
            float pesado = 0;
            float leve = 0;
            for (int i = 0; continuar == "S"; i++)
            {     
                var pessoa = new List<dynamic>();
                Console.Write("Digite o nome: ");
                var nome = Console.ReadLine();
                pessoa.Add(nome);

                Console.Write("Digite o peso: ");
                var peso = float.Parse(Console.ReadLine());
                pessoa.Add(peso);

                cadastro.Add(pessoa);

                cadastroEstruturado.Add(new {
                    Nome = nome,
                    Peso = peso
                });
                contador++;
                
                Console.Write("Quer continuar? [S/N]: ");
                continuar = Console.ReadLine().ToUpper();
                while (continuar != "S" && continuar != "N")
                {
                    Console.Write("Valor inválido. Para continuar digite S e para " +
                        "encerrar digite N. [S/N]: ");
                    continuar = Console.ReadLine().ToUpper();
                }               
            }
            string sustenido = "#################################";
            Console.WriteLine(sustenido);
            for (int x = 0; x < cadastro.Count; x++)
            {
                Console.Write("Nome: " + cadastro[x][0]);
                Console.WriteLine(" peso: " + cadastro[x][1]);
            }
            Console.WriteLine(sustenido);
            foreach (var obj in cadastroEstruturado)
            {
                Console.Write("Nome: " + obj.Nome);
                Console.WriteLine(" peso: " + obj.Peso);

                if (obj[cadastroEstruturado] == 0)
                {
                    pesado = obj;
                    cadastroEstruturado[i];
                }
                else if (cadastroEstruturado > )
                {

                }
            }
            Console.WriteLine(sustenido);
        }
    }
}
