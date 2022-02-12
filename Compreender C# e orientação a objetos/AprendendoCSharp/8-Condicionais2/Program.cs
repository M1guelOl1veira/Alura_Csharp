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
            Console.WriteLine("Inciando o projeto 8 - Condicional2");

            int idade = 17;
            int quantidade_Pessoas = 3;
            bool acompanhado = quantidade_Pessoas >= 2;

            if (idade >= 18 && acompanhado)
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
