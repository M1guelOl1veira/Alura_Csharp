using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Titular = new Cliente();
            conta.Titular.Nome = "Miguel";
            Console.WriteLine(conta.Titular.Nome);

            conta.Saldo = 200;
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
            
        }
    }
}
