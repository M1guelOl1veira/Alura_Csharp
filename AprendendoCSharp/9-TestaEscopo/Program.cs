using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inciando o projeto 9 - TestaEscopo");

            int idade = 17;
            int quantidade_Pessoas = 3;
            bool acompanhado;

            if (quantidade_Pessoas >= 2)
            {
                acompanhado = true;
            }
            else
            {
                acompanhado = false;
            }

            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }

            Console.ReadLine();
        }
    }
}