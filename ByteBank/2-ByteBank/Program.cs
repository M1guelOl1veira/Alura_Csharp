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
            Console.WriteLine("Saldo da conta");
            Console.WriteLine(conta.saldo);
            Console.WriteLine();

            conta.saldo += 100;
            Console.WriteLine("Saldo da conta após acréscimo");
            Console.WriteLine(conta.saldo);
            Console.WriteLine();

            ContaCorrente segundaConta = new ContaCorrente();
            segundaConta.saldo = 50;
            Console.WriteLine("Saldo da segunda conta");
            Console.WriteLine(segundaConta.saldo);
            Console.WriteLine();

            Console.WriteLine("Primeira conta tem " + conta.saldo);
            Console.WriteLine("Segunda conta tem " + segundaConta.saldo);
            Console.WriteLine();

            //Testando método depositar:
            conta.Depositar(100);
            Console.WriteLine("Saldo da conta após depósito");
            Console.WriteLine(conta.saldo);
            Console.WriteLine();

            //Testando método sacar:
            bool resultadoSacar = conta.Sacar(500);
            Console.WriteLine("Saldo da conta após sacar");
            Console.WriteLine(resultadoSacar);

            resultadoSacar =  conta.Sacar(200);
            Console.WriteLine(conta.saldo);
            Console.WriteLine(resultadoSacar);
            Console.WriteLine();

            //Testando método transferir:
            bool resultadoTransferir = conta.Transferir(500, segundaConta);
            Console.WriteLine("Resultado após transferir");
            Console.WriteLine(resultadoTransferir);

            resultadoTransferir = conta.Transferir(100, segundaConta);
            Console.WriteLine(conta.saldo);
            Console.WriteLine(resultadoTransferir);

            Console.ReadLine();

        }
    }
}
