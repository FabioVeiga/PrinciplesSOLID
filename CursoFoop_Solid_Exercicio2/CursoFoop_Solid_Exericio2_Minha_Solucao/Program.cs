using CursoFoop_Solid_Exericio2_Minha_Solucao.Model;
using System;

namespace CursoFoop_Solid_Exericio2_Minha_Solucao
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerConsole = new ConsoleLogger();
            var loggerArquivo= new ArquivoLogger();

            var pedido = new Pedido(loggerConsole,loggerArquivo);

            pedido.AdicionarPedido();
        }
    }
}
