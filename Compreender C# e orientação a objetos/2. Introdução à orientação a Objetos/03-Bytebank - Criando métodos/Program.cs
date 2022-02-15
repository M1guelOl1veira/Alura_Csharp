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
            ContaCorrente segundaConta = new ContaCorrente();
            
            Console.WriteLine(primeiraConta.saldo);

            bool resultadoSacar = primeiraConta.Sacar(50);

            Console.WriteLine(primeiraConta.saldo);
            Console.WriteLine(resultadoSacar);

            resultadoSacar = segundaConta.Sacar(300);
            Console.WriteLine(segundaConta.saldo);
            Console.WriteLine(resultadoSacar);

            primeiraConta.Depositar(100);
            Console.WriteLine(primeiraConta.saldo);

            bool resultadoTransferir = primeiraConta.Transferir(segundaConta, 100);
            Console.WriteLine(primeiraConta.saldo);
            Console.WriteLine(segundaConta.saldo);

            Console.ReadLine();
        }
    }
}
