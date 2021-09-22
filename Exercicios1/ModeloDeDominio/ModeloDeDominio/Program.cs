using System;

namespace ModeloDeDominio
{
    class Program
    {
        static void Main(string[] args)
        {
            //modelo anemico
            ClienteAnemico clienteAnemico = new ClienteAnemico();
            clienteAnemico.Nome = "";
            clienteAnemico.Id = -1;
            clienteAnemico.Endereco = null;
            Console.WriteLine($"ID = {clienteAnemico.Id}, " +
                $"Nome = {clienteAnemico.Nome} - " +
                $"Idade = {clienteAnemico.Id}");

            //Cliente rico
            ClienteRico clienteRico = new ClienteRico(-1,"Fabio", "Teste");
            Console.WriteLine($"ID = {clienteRico.Id}, " +
                $"Nome = {clienteRico.Nome} - " +
                $"Idade = {clienteRico.Id}");

            Console.ReadLine();

        }
    }
}
