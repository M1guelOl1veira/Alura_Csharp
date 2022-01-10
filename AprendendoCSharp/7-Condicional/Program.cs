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
            Console.WriteLine("Inciando o projeto 7 - Condicional");

            int idade = 17;
            int quantidade_Pessoas = 3;

            if (idade >= 18)
            {
                Console.WriteLine("Idade é maior ou igual a 18 anos, pode entrar!");
            }
            else
            {
                if (quantidade_Pessoas >= 2)
                {
                    Console.WriteLine("Idade é menor que 18 anos, mas está acompanhado." +
                        "Pode entrar!");
                }
                else
                {
                    Console.WriteLine("Idade é menor que 18 anos, não pode entrar!");
                }
                
            }


            Console.ReadLine();
        }
    }
}
