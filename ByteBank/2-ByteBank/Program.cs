using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.saldo = 200;
            Console.WriteLine(conta.saldo);

            conta.saldo += 100;
            Console.WriteLine(conta.saldo);

            ContaCorrente segundaConta = new ContaCorrente();
            segundaConta.saldo = 50;
            Console.WriteLine(segundaConta);

            Console.WriteLine("Primeira conta tem " + conta.saldo);
            Console.WriteLine("Segunda conta tem " + segundaConta.saldo);
            
            Console.ReadLine();

        }
    }
}
