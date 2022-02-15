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
            //Para criar uma biblioteca é necessário referenciá-lo em um projeto da mesma solução e compilá-lo.
            //A DLL será gerada na pasta do projeto bin/debug.
            //Para utizá-la em outro projeto é necessário referenciá-la através do botão procurar.
            ContaCorrente conta = new ContaCorrente(847, 489754);


            FuncionarioAutenticavel carlos = null;
            carlos.Autenticar("kjhasfkjas");

            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
