using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra = 'a'; //char guarda apenas um caractere da tabela ascii.
            Console.WriteLine(letra);

            char valor = (char)65;
            Console.WriteLine(valor);

            valor = (char)(valor + 1); //char + int = int
            Console.WriteLine(valor);

            string palavra = "Alura Cursos Online de Tecnologia ";
            Console.WriteLine(palavra);

            palavra = palavra + 2020; //C# converte o número para string e soma.
            Console.WriteLine(palavra);






            Console.ReadLine();
        }
    }
}
