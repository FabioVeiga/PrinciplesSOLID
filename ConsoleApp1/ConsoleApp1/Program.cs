using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Paulo";
            pessoa.Idade = 45;
            pessoa.Sexo = "Masculino";
            pessoa.Identificar();
        }
    }
}
