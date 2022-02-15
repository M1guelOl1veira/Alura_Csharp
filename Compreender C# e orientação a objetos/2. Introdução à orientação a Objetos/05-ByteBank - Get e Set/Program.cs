using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente Conta = new ContaCorrente();
            Conta.Titular = new Cliente();

            Conta.Titular.Nome = "Miguel";

            Conta.Saldo = -10;

            Console.WriteLine(Conta.Titular.Nome);
            Console.WriteLine(Conta.Saldo);

            Console.ReadLine();
        }
    }
}

