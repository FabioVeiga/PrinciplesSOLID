using System;

namespace Exercicio09
{
    class Transacao : ConectarBancoDados, ITransacao, IRelatorio
    {
        public void Executa()
        {
            Console.WriteLine("Processando Transação...");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimir Transação...");
        }
    }
}
