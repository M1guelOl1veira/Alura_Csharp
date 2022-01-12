using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F16_Desafio_Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1;

            //int contador = 1;
            for (int linha = 1; linha < 11; linha++)
            {
                fatorial *= linha;
                Console.WriteLine(fatorial);
            }
            Console.ReadLine();
        }
    }
}


