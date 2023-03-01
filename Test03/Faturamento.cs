using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test03
{
    public class Faturamento
    {
        public Faturamento(int dia, decimal valor)
        {
            Dia = dia;
            Valor = valor;
        }

        public int Dia { get; set; }
        public decimal Valor { get; set; }
          
    }
}