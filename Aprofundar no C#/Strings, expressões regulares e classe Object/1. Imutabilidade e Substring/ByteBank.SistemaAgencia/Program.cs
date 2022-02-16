using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "pagina?argumentos";

            url.Substring(7);

            //No C# strings são imutáveis.
            Console.WriteLine(url);


            url += "sufixo";
            //Isso é o que acontece quando concatenamos strings em C#.
            string temporaria = url + "sufixo";
            url = temporaria;

            
            //Substring retorna uma porção da string a parte do index escolhido, incluindo o index.
            string teste = url.Substring(7);

            Console.WriteLine(teste);

            Console.ReadLine();


            Console.ReadLine();
        }
    }


}
