using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string palavraReverter = "";
            int somando = 0;
            Console.WriteLine("Digite uma palavra: ");
            palavraReverter = Console.ReadLine();

            char[] palavraArray = palavraReverter.ToCharArray();
            char[] reverter = new char[palavraArray.Length];

            for (int i = palavraArray.Length; i > 0; i--)
            {                
                reverter[somando] = palavraArray[i-1];
                somando++;
            }
            palavraReverter = new String(reverter);
            Console.WriteLine(palavraReverter);

            Console.ReadKey();
        }
    }
}
