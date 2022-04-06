using System;

namespace Exercicio070
{
    //70) Crie um programa que leia o nome e o
    //preço de vários produtos. O programa deverá
    //perguntar se o usuário vai continuar ou não.
    //No final, mostre:
    //A) qual é o total gasto na compra.
    //B) quantos produtos custam mais de R$1000.
    //C) qual é o nome do produto mais barato.
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "";
            float total = 0;
            int maisQMil = 0;
            string maisBarato = "";
            float menorPreco = 0;
            int contador = 0;
            while (continuar != "N")
            {
                Console.Write("Digite o nome do produto: ");
                string produto = Console.ReadLine();
                Console.Write("Digite o valor do produto: R$");
                float preco = float.Parse(Console.ReadLine());
                Console.Write("Quer continuar? [S/N]: ");
                contador += 1;
                total += preco;
                if (preco > 1000)
                {
                    maisQMil += 1;
                }
                if (contador == 1)
                {
                    maisBarato = produto;
                    menorPreco = preco;
                } else if (preco < menorPreco) {
                    menorPreco = preco;
                    maisBarato = produto;
                }
                continuar = Console.ReadLine().ToUpper();
            }
            Console.WriteLine($"O total gasto na compra é R${total:f2}");
            Console.WriteLine($"A quantidade de produtos custam mais de R$1000,00" +
                $" é {maisQMil}");
            Console.WriteLine($"O nome do produto mais barato é {maisBarato.ToUpper()}" +
                $" com o valor de {menorPreco:f2}");
        }
    }
}
