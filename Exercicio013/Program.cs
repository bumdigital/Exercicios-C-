using System;

namespace Exercicio013
{
    //13) Faça um algoritmo que leia o salário
    //de um funcionário e mostre seu novo salário,
    //com 15% de aumento.
    class Program
    {
        static void Main(string[] args)
        {
            float salario;
            Console.Write("Digite o salário atual R$");
            salario = float.Parse(Console.ReadLine());
            float aumento = (salario / 100) * 15;
            salario += aumento;
            Console.WriteLine($"O novo salário com 15% de aumento é {salario:f2}");
        }
    }
}
