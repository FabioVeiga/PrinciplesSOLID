﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoo_Exercicio3_Minha_Reposta
{
    class CalcularImpostoBrazil : ICalcularImpostoPais
    {
        public decimal TotalRenda { get; set; }
        public decimal TotalReducao { get; set; }
        public CalcularImpostoBrazil(decimal totalRenda, decimal totalReducao)
        {
            TotalRenda = totalRenda;
            TotalReducao = totalReducao;
        }
        public decimal CalcularImposto()
        {
            return (TotalRenda - TotalReducao) * Contantes.VALOR_JUROS_BRAZIL;
        }
    }
}
