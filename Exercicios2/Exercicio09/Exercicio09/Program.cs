using System;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            var transacao = new Transacao();
            transacao.Conectar();
            transacao.Executa();
            transacao.Imprimir();

            Console.ReadLine();
        }
    }
}
