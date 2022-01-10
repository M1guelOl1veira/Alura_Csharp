using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoeseOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 1270.5;
            int valor = (int)salario; //int armazena 32 bits.
            Console.WriteLine(valor);

            double variavel1 = 12.8;
            double variavel2 = 14.5;
            double variavel3 = variavel1 + variavel2;  
            Console.WriteLine(variavel3);

            double variavel4 = 15.0;
            Console.WriteLine(variavel4);


            float PontoFlutuante = 1.8f; //O float possui uma precisão de casas decimais menor que a do double. 
            Console.WriteLine(PontoFlutuante);

            short VariavelShort = 15000; //É uma variável do tipo inteiro que ocupa 16 bits na memória.
            Console.WriteLine(VariavelShort);

            long VariavelLong = 13000000000; //Também é do tipo inteiro, armazena 64 bits.
            Console.WriteLine(VariavelLong);

            Console.ReadLine();


        }
    }
}
