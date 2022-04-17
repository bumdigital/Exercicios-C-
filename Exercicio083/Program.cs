using System;

namespace Exercicio083
{
    //83) Crie um programa onde o usuário digite uma
    //expressão qualquer que use parênteses. Seu aplicativo
    //deverá analisar se a expressão passada está com os
    //parênteses abertos e fechados na ordem correta.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma expressão: ");
            string expressao = Console.ReadLine();
            int contAbrindo = 0;
            int contFechando = 0;
            for (int i = 0; i < expressao.Length; i++)
            {
                if (expressao[i].ToString() == "(")
                {
                    contAbrindo++;
                    for (int j = i; j < expressao.Length; j++)
                    {
                        if (expressao[j].ToString() == ")")
                        {
                            contFechando++;
                            break;
                        }
                    }
                }
            }
            if (contAbrindo == contFechando)
            {
                Console.WriteLine("A expressão está correta!");
            } else 
            {
                Console.WriteLine("A expressão está errada!");
            }
        }
    }
}
