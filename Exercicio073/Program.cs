using System;

namespace Exercicio073
{
    //73) Crie uma tupla preenchida com os 20 primeiros 
    //    colocados da Tabela do Campeonato Brasileiro de 
    //    Futebol, na ordem de colocação.Depois mostre:
    //a) Os 5 primeiros times.
    //b) Os últimos 4 colocados.
    //c) Times em ordem alfabética.
    //d) Em que posição está o time da Chapecoense.

    class Program
    {
        static void Main(string[] args)
        {
            String[] times = {"Flamengo", "Palmeiras", "Atlético Mineiro", "Grêmio",
                "Athletico Paranaense", "Santos", "São Paulo", "Internacional",
                "Fluminense", "Corinthians", "Fortaleza", "Bahia", "Ceará", "Cruzeiro",
                "América Mineiro", "Atlético Goianiense", "Chapecoense", "Botafogo",
                "Vasco da Gama", "Red Bull Bragantino"};
            Console.WriteLine("Os 5 primeiros colocados são:");
            Console.WriteLine("################################");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{times[i]}");
            }
            Console.WriteLine("################################");
            Console.WriteLine("Os 4 últimos colocados são:");
            Console.WriteLine("################################");
            for (int i = times.Length -4 ; i < times.Length; i++)
            {
                Console.WriteLine($"{times[i]}");
            }
            Console.WriteLine("################################");
            Console.WriteLine($"O Chapecoence está na {Array.IndexOf(times, "Chapecoense")+1}° posição");
        }
    }
}
