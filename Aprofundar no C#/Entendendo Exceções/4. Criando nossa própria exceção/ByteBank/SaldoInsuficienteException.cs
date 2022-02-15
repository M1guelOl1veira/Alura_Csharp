using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    //Quando criar uma exceção é convenção adicionar Exception no final do nome da classe.
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }


        //Construtor sem argumento é comum em exceções.
        public SaldoInsuficienteException()
        {

        }

        //O this chama o construtor da própria classe.
        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Tentativa de saque do valor de " + valorSaque + " em uma conta com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        //Construtor com mensagem é comum em exceções.
        public SaldoInsuficienteException(string mensagem)
            : base(mensagem)
        {
        }
    }
}
