using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoDiarioDistribuidora
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<FaturamentoDiarioMes> faturamento = new List<FaturamentoDiarioMes>();
            FaturamentoDiarioMes faturamentoMenorDiario = new FaturamentoDiarioMes();
            FaturamentoDiarioMes faturamentoMaiorDiario = new FaturamentoDiarioMes();
            decimal mediaMensal = 0;
            int countDias = 0;
            var jsonString = "";

            StreamReader sr = new StreamReader("../../dados.json");
            jsonString = sr.ReadToEnd();
            
            faturamento = JsonConvert.DeserializeObject<List<FaturamentoDiarioMes>>(jsonString);

            foreach (FaturamentoDiarioMes s in faturamento)
            {
                if (s.Valor != 0)
                {
                    faturamentoMenorDiario = s;
                    break;
                }
                
            }

            foreach (FaturamentoDiarioMes s in faturamento)
            {
                if (s.Valor != 0 && s.Valor < faturamentoMenorDiario.Valor)
                {
                    faturamentoMenorDiario = s;
                }
                if (s.Valor > faturamentoMaiorDiario.Valor)
                {
                    faturamentoMaiorDiario = s;
                }
                if (s.Valor != 0)
                {
                    mediaMensal = mediaMensal + s.Valor;
                    countDias++;
                }
            }
            mediaMensal = mediaMensal / countDias;

            countDias = 0;
            foreach (FaturamentoDiarioMes s in faturamento)
            {
                
                if(s.Valor > mediaMensal)
                {
                    countDias++;
                }
            }
              
            Console.WriteLine("O menor valor de faturamento ocorrido em um dia do mês é : " + faturamentoMenorDiario.Valor);
            Console.WriteLine("O maior valor de faturamento ocorrido em um dia do mês é : " + faturamentoMaiorDiario.Valor);
            Console.WriteLine("Número de dias no mês em que o valor de faturamento diário foi superior à média mensal : " + countDias);

            Console.ReadKey();
        }
    }
}
