using System;

namespace Exercicio059
{
    //59) Crie um programa que leia dois valores e mostre um menu na tela:
    //[ 1 ] somar 
    //[ 2 ] multiplicar
    //[ 3 ] maior
    //[ 4 ] novos números
    //[ 5 ] sair do programa
    //Seu programa deverá realizar a operação solicitada em cada caso.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine()); ;
            Console.Write("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine()); ;
            string opcoes = "[ 1 ] somar\n" +
                "[ 2 ] multiplicar\n" +
                "[ 3 ] maior\n" +
                "[ 4 ] novos números\n" +
                "[ 5 ] sair do programa";
            int opcao = 0;           
            while (opcao != 5)
            {
                Console.WriteLine(opcoes);
                Console.Write("Digite uma das opções: ");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                if (opcao == 1)
                {
                    int soma = n1 + n2;
                    Console.WriteLine($"O resultado de {n1} + {n2} é {soma}");
                } else if (opcao == 2)
                {
                    int mult = n1 * n2;
                    Console.WriteLine($"O resultado de {n1} x {n2} é {mult}");
                } else if (opcao == 3)
                {
                    int maior = 0;
                    if (n1 > n2)
                    {
                        maior = n1;
                        Console.WriteLine($"O maior numero entre os dois é {maior}");
                    } else if (n2 > n1)
                    {
                        maior = n2;
                        Console.WriteLine($"O maior numero entre os dois é {maior}");
                    }
                    else
                    {
                        Console.WriteLine($"Os numeros {n1} e {n2} são iguais. \n" +
                            $"Não há numero maior nesse caso.");
                    }
                } else if (opcao == 4)
                {
                    Console.Write("Digite o primeiro numero: ");
                    n1 = int.Parse(Console.ReadLine()); ;
                    Console.Write("Digite o segundo numero: ");
                    n2 = int.Parse(Console.ReadLine()); ;
                }
            }
        }        
    }
}
