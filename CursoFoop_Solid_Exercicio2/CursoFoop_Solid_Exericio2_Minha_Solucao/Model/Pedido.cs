using CursoFoop_Solid_Exericio2_Minha_Solucao.Interfaces;
using System;

namespace CursoFoop_Solid_Exericio2_Minha_Solucao
{
    public class Pedido
    {
        private readonly IConsoleLogger _consoleLogger;
        private readonly IArquivoLogger _arquivoLogger;

        public Pedido(IConsoleLogger consoleLogger, IArquivoLogger arquivoLogger)
        {
            _consoleLogger = consoleLogger;
            _arquivoLogger = arquivoLogger;
        }
        public virtual void AdicionarPedido()
        {
            try
            {
                //código para validar e incluir pedido
                _consoleLogger.RegistrarMensagemNoConsole($"Pedido Incluido em :  {DateTime.Now}");
                _arquivoLogger.RegistrarMensagemNoArquivo($"Pedido Incluido em :  {DateTime.Now}");
            }
            catch (Exception ex)
            {
                _consoleLogger.RegistrarMensagemNoConsole($"{ex} - {DateTime.Now}");
                _arquivoLogger.RegistrarMensagemNoArquivo($"{ex} - {DateTime.Now}");
            }
        }
    }
}
