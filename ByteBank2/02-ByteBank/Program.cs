using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente primeiraConta = new ContaCorrente();
            primeiraConta.saldo = 200;
            Console.WriteLine(primeiraConta.saldo);

            primeiraConta.saldo += 100;
            Console.WriteLine(primeiraConta.saldo);

            ContaCorrente segundaContaCorrente = new ContaCorrente();
            segundaContaCorrente.saldo = 50;
            Console.WriteLine(segundaContaCorrente.saldo);

            Console.ReadLine();
        }
    }
}
