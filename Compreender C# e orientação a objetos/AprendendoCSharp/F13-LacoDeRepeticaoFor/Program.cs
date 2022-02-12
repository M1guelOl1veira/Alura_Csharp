using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F13_LacoDeRepeticaoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int numero = 1; numero <= 10; numero++)
            {
                for (int contador = 0; contador <=10; contador++)
                {
                    Console.WriteLine(numero + " * " + contador + " = " + numero * contador);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
                
            Console.ReadLine();
        }
    }
}
