using System;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            p1.nome = "Bob";
            p1.idade = 20;

            p1.Apresentar();
        }
    }
}