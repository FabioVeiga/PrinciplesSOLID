using CursoFoop_Solid_Exericio2_Minha_Solucao.Interfaces;
using System;
using System.IO;

namespace CursoFoop_Solid_Exericio2_Minha_Solucao.Model
{
    class ArquivoLogger : IArquivoLogger
    {
        public void RegistrarMensagemNoArquivo(string mensagem)
        {
            var pasta = Directory.GetCurrentDirectory();
            var arquivo = Path.Combine(pasta, "log.txt");

            using(StreamWriter sw = new StreamWriter(arquivo, true))
            {
                sw.WriteLine(mensagem);
            }
        }
    }
}
