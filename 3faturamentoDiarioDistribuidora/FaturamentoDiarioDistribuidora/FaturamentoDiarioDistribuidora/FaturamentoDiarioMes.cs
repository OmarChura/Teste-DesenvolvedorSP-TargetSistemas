using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoDiarioDistribuidora
{
    class FaturamentoDiarioMes
    {
        public int Dia { get; set; }
        public decimal Valor { get; set; }

        public FaturamentoDiarioMes()
        {
            Dia = 0;
            Valor = 0;
        }
        public FaturamentoDiarioMes(int dia, decimal valor)
        {
            this.Dia = dia;
            this.Valor = valor;
        }
    }
}
