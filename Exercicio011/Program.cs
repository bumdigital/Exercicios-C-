using System;

namespace Exercicio011
{
    //11)  Faça um programa que leia a largura e a
    //altura de uma parede em metros, calcule a sua
    //área e a quantidade de tinta necessária para
    //pintá-la, sabendo que cada litro de tinta
    //pinta uma área de 2 metros quadrados.
    class Program
    {
        static void Main(string[] args)
        {
            float largura;
            float altura;
            float area;
            float tinta;
            Console.Write("Digite a largura: ");
            largura = float.Parse(Console.ReadLine());
            Console.Write("Digite a altura: ");
            altura = float.Parse(Console.ReadLine());
            area = largura * altura;
            Console.WriteLine($"A area é {area}");
            tinta = area / 2;
            Console.WriteLine($"Para pintar a parede são necessarios {tinta}" +
                $" litros de tinta");
        }
    }
}
