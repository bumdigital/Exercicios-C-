using System;

namespace Exercicio072
{
    //72) Crie um programa que tenha uma dupla totalmente
    //preenchida com uma contagem por extenso, de zero até
    //vinte. Seu programa deverá ler um número pelo teclado
    //(entre 0 e 20) e mostrá-lo por extenso.
    class Program
    {
        static void Main(string[] args)
        {
            String[] numeros = {"zero", "um", "dois", "três", "quatro",
            "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze", "treze",
            "quatorze", "quinze", "dezesseis", "dezessete", "dezoioto", "dezenove",
            "vinte"};
            string continuar = "S";
            while (continuar == "S")
            {
                Console.Write("Digite um numero: ");
                int numero = int.Parse(Console.ReadLine());
                while (numero < 0 || numero > 20)
                {
                    Console.Write("Numero fora do intervalo de 0 a 20. Digite novamente: ");
                    numero = int.Parse(Console.ReadLine());
                }           
                for (int i = 0; i <= 20; i++)
                {
                    string numerosIndex = numeros[i];
                    int index = Array.IndexOf(numeros, numerosIndex);
                    if (numero == index)
                    {
                        Console.WriteLine($"Você digitou o numero {numeros[i].ToUpper()}");
                    }
                }
                Console.Write("Quer continuar? [S/N]: ");
                continuar = Console.ReadLine().ToUpper();
                while (continuar != "S" && continuar != "N")
                {
                    Console.Write("Resposta invalida. Para continuar digite S " +
                        "e para encerrar digite N [S/N]: ");
                    continuar = Console.ReadLine().ToUpper();
                }
            }
        }
    }
}
