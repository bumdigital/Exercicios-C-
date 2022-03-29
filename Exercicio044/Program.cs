using System;

namespace Exercicio044
{
    //44) Elabore um programa que calcule o valor
    //a ser pago por um produto, considerando o
    //seu preço normal e condição de pagamento:
    //- à vista dinheiro/cheque: 10% de desconto
    //- à vista no cartão: 5% de desconto
    //- em até 2x no cartão: preço formal
    //- 3x ou mais no cartão: 20% de juros
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o preço do produto: ");
            float preco = float.Parse(Console.ReadLine());
            Console.Write("Escolha uma das condições de pagamento, sendo:\n" +
                "- à vista dinheiro/cheque: 10% de desconto [ 1 ]\n" +
                "- à vista no cartão: 5% de desconto        [ 2 ]\n" +
                "- em até 2x no cartão: preço formal        [ 3 ]\n" +
                "- 3x ou mais no cartão: 20% de juros       [ 4 ]\n" +
                "escolha: ");
            int condicao = int.Parse(Console.ReadLine());
            if (condicao == 1)
            {
                preco -= (preco / 100) * 10;
                Console.WriteLine("O valor do produto com a condição de " +
                    $"pagamento escolhoda é R${preco:f2}");
            }
            else if (condicao == 2)
            {
                preco -= (preco / 100) * 5;
                Console.WriteLine("O valor do produto com a condição de " +
                    $"pagamento escolhoda é R${preco:f2}");
            }
            else if (condicao == 3)
            {
                Console.WriteLine("O valor do produto com a condição de " +
                    $"pagamento escolhoda é R${preco:f2}");
            }
            else if (condicao == 4)
            {
                preco += (preco / 100) * 20;
                Console.WriteLine("O valor do produto com a condição de " +
                    $"pagamento escolhoda é R${preco:f2}");
            }
            else
            {
                Console.WriteLine("Condição inexistente");
            }
        }
    }
}
