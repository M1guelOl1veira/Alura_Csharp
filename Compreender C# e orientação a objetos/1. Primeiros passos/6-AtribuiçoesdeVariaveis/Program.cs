using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuiçoesdeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            int idadedois = idade; //Igualar elas é o mesmo que copiar o valor de idade para idadedois.
                                   //Variáveis guardam valores e não referências.

            idade = 20;

            Console.WriteLine(idade);

            Console.WriteLine(idadedois);

            Console.ReadLine();
        }
    }
}
