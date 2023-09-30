using System;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno();
            p1.Nome = "Bob";
            p1.Idade = 30;
            p1.Documento = "25698845687";

            p1.Apresentar();

        }
    }
}