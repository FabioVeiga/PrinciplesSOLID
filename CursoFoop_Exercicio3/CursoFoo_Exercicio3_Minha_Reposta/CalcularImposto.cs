using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoo_Exercicio3_Minha_Reposta
{
    class CalcularImposto
    {
        public decimal Calcular(ICalcularImpostoPais icalc)
        {
            return icalc.CalcularImposto();
        }
    }
}
