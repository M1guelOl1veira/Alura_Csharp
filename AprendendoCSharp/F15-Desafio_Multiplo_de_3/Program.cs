using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F15_Desafio_Multiplo_de_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int multi = 1; multi < 100;  multi++)
            {
                //Console.WriteLine(3 + " * " + multi + " = " + multi*3);
                if (multi % 3 == 0)
                {
                    Console.WriteLine(multi);
                }
            }
            Console.ReadLine();
        }
    }
}
