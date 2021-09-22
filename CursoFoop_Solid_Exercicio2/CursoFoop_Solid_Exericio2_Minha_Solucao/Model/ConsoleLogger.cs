using CursoFoop_Solid_Exericio2_Minha_Solucao.Interfaces;
using System;

namespace CursoFoop_Solid_Exericio2_Minha_Solucao
{
    class ConsoleLogger : IConsoleLogger
    {
        public void RegistrarMensagemNoConsole(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
