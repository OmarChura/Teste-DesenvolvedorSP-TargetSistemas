using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoMensalDistribuidoraPorEstado
{
    public class FaturamentoEstado
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public FaturamentoEstado()
        {
            Nome = "";
            Valor = 0;
        }

        public FaturamentoEstado(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
