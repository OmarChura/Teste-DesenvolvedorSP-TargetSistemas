using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoMensalDistribuidoraPorEstado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<FaturamentoEstado> faturamentos = new List<FaturamentoEstado>();
            //prenchendo a lista de objetos 
            FaturamentoEstado SP = new FaturamentoEstado("SP",67836.43);
            FaturamentoEstado RJ = new FaturamentoEstado("RJ", 36678.66);
            FaturamentoEstado MG = new FaturamentoEstado("MG", 29229.88);
            FaturamentoEstado ES = new FaturamentoEstado("ES", 27165.48);
            FaturamentoEstado Outros = new FaturamentoEstado("Outros", 19849.53);
            faturamentos.Add(SP);
            faturamentos.Add(RJ);
            faturamentos.Add(MG);
            faturamentos.Add(ES);
            faturamentos.Add(Outros);
            ///-------------------------------------------------------
            double porcentageTotal = 1.0;
            double porcentage = 0;
            double valorTotal = 0;

            foreach(FaturamentoEstado faturamento in faturamentos)
            {
                valorTotal = valorTotal + faturamento.Valor;
            }

            for (int i = 0; i < faturamentos.Count(); i++)
            {
                porcentage = ((faturamentos[i].Valor * porcentageTotal) / valorTotal) * 100;

                Console.WriteLine("percentual do estado de " + faturamentos[i].Nome + ": " + porcentage.ToString("F") + " %");
            }
            Console.WriteLine("Valor Total: " + valorTotal.ToString("C"));

            Console.ReadKey();
        }
    }
}
