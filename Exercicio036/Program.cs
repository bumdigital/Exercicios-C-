using System;

namespace Exercicio036
{
    //36) Escreva um programa para aprovar o empréstimo
    //bancário para a compra de uma casa. Pergunte o
    //valor da casa, o salário do comprador e em quantos
    //anos ele vai pagar. A prestação mensal não pode exceder
    //30% do salário ou então o empréstimo será negado.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da casa: ");
            float valorCasa = float.Parse(Console.ReadLine());
            Console.Write("Digite seu salário: ");
            float salario = float.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de anos para pagar o empréstimo: ");
            float anosPrazo = float.Parse(Console.ReadLine());

            float parcela = (valorCasa / anosPrazo) / 12;
            if (parcela > (salario / 100) * 30)
            {
                Console.WriteLine("O valor da parcela é maior que 30% do salário. " +
                    "Emprestimo negado");
            }
            else
            {
                Console.WriteLine("Emprestimo aprovado");
            }
        }
    }
}
