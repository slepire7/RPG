using RPG.Entities;
using System;

namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Guerreiro = new Guerreiro("Arus", 20, "Intermediario", 100, 100);
            var Mago = new Mago("Figurante", 30, "Supremo", 80, 500);
            Console.WriteLine($"{Guerreiro}{Environment.NewLine} vs {Environment.NewLine}{Mago}");
            Console.WriteLine(Guerreiro.Atacar(7, Mago));
            Console.WriteLine(Mago.Atacar(9, Guerreiro));
            Console.WriteLine($"Resultado");
            Console.WriteLine($"{Guerreiro}{Environment.NewLine} vs {Environment.NewLine}{Mago}");
            Console.ReadKey();
        }
    }
}
