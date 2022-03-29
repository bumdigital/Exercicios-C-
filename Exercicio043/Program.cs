using System;

namespace Exercicio043
{
    //43) Desenvolva uma lógica que leia o
    //peso e a altura de uma pessoa, calcule
    //seu Índice de Massa Corporal (IMC) e
    //mostre seu status, de acordo com a
    //tabela abaixo:
    //- IMC abaixo de 18,5: Abaixo do Peso
    //- Entre 18,5 e 25: Peso Ideal
    //- 25 até 30: Sobrepeso
    //- 30 até 40: Obesidade
    //- Acima de 40: Obesidade Mórbida
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite dua altura: ");
            float altura = float.Parse(Console.ReadLine());
            Console.Write("Digite seu peso: ");
            float peso = float.Parse(Console.ReadLine());
            Console.Write("Digite H para masculino e F para feminino: ");
            string sexo = (Console.ReadLine().ToUpper());
            float alturaAoQuadrado = (float)Math.Pow(altura, 2);
            float imc = (float)(peso * alturaAoQuadrado); ; 
            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do Peso");
            } else if (imc >= 18.5 && imc <= 25)
            {
                Console.WriteLine("Peso Ideal");
            } else if (imc >= 25 && imc <= 30)
            {
                Console.WriteLine("Sobrepeso");
            } else if (imc >= 30 && imc <= 40)
            {
                Console.WriteLine("Obesidade");
            } else if (imc > 40)
            {
                Console.WriteLine("Obesidade morbida");
            }
        }
    }
}
