using System;

namespace Exercicio069
{
    //69) Crie um programa que leia a idade e o sexo
    //de várias pessoas. A cada pessoa cadastrada, o
    //programa deverá perguntar se o usuário quer ou
    //não continuar. No final, mostre:
    //A) quantas pessoas tem mais de 18 anos.
    //B) quantos homens foram cadastrados.
    //C) quantas mulheres tem menos de 20 anos.
    class Program
    {
        static void Main(string[] args)
        {
            int pessoasM18 = 0;
            int homensCdast = 0;
            int mulheresM20 = 0;
            string continuar = "";
            while (continuar != "N")
            {
                Console.Write("Digite sua idade: ");
                int idade = int.Parse(Console.ReadLine());
                Console.Write("DIgite o sexo [F/M]: ");
                string sexo = Console.ReadLine().ToUpper(); ; 
                while (sexo != "F" && sexo != "M")
                {
                    Console.Write("Valor invalido para sexo. Digite novamento [F/M]: ");
                    sexo = Console.ReadLine().ToUpper();
                }
                if (idade > 18)
                {
                    pessoasM18 += 1;
                }
                if (sexo == "M")
                {
                    homensCdast += 1;
                }
                if (idade < 20 && sexo == "F")
                {
                    mulheresM20 += 1;
                }
                Console.Write("Quer continuar? [S/N]: ");
                continuar = Console.ReadLine().ToUpper();
            }
            Console.WriteLine($"{pessoasM18} pessoas tem mais de 18 anos");
            Console.WriteLine($"{homensCdast} homens foram cadastrados");
            Console.WriteLine($"{mulheresM20} mulheres tem menos de 20 anos");
        }
    }
}
