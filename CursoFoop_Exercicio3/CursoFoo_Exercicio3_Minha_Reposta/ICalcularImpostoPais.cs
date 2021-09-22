using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoo_Exercicio3_Minha_Reposta
{
    public interface ICalcularImpostoPais
    {
        public decimal TotalRenda  { get; set; }
        public decimal TotalReducao  { get; set; }
        decimal CalcularImposto();
    }
}
