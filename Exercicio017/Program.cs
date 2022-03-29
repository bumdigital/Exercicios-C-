using System;

namespace Exercicio017
{
    //17) Faça um programa que leia o comprimento
    //do cateto oposto e do cateto adjacente de um
    //triângulo retângulo.Calcule e mostre o
    //comprimento da hipotenusa.

    //REFAZER EXERCICIO - (AINDA ESTÁ ERRADO)##############################
    class Program
    {
        static void Main(string[] args)
        {
            float catetoOposto;
            float catetoAdjacente;
            Console.Write("Digite o comprimento do cateto oposto: ");
            catetoOposto = float.Parse(Console.ReadLine());
            Console.Write("Digite o comprimento do cateto adjacente: ");
            catetoAdjacente = float.Parse(Console.ReadLine());
            float quadHipotenusa = (float)(Math.Pow(catetoOposto, 2) + Math.Pow(catetoAdjacente, 2));
            //float contador;
            //float acumulador;
            for (float i= 1, resto = 1, contador =0; resto >= 0; i++ )
            {
                if (i % 2 > 0)
                {
                    resto = quadHipotenusa - i;
                    contador += 1;
                    if (resto == 0)
                        Console.WriteLine($"A hipotenusa é {contador}");
                }
            }
        }
    }
}
