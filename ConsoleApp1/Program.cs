using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa person = new Pessoa();

            person.Nome = "Geremias";
            person.Idade = 20;
            person.Estado = "SP";

            var person2 = new Pessoa();

            person2.Nome = "Antony";
            person2.Idade = 18;
            person2.Estado = "MG";
        }
    }
}
