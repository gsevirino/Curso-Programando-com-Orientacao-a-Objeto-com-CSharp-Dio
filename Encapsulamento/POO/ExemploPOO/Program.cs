using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();
            r.DefinirMedidas(30, 30);

            System.Console.WriteLine($"Área: {r.ObterArea()}");
        }
    }
}