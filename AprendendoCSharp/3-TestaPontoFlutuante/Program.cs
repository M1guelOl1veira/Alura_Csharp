using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_TestaPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 3 - Variável Double");

            double salario = 1250.70;

            Console.WriteLine("O salário é no valor de " + salario);

            int divisao = 5 / 2;
            Console.WriteLine(divisao); //Divisão de int por int, resultado será int.
                                        //Ele apenas retira a parte decimal.

            double divisao2 = 5.0 / 2;
            Console.WriteLine(divisao2);

            Console.ReadLine();



            


        }
    }
}
