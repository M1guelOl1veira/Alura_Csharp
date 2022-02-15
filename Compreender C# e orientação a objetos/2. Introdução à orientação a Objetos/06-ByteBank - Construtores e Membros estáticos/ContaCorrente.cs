using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank___Construtores_e_Membros_estáticos
{
    class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        //Construtor: Não deixa instanciar um objeto sem que os valores dos argumentos sejam passados.
        public ContaCorrente(int conta, int agencia)
        {
            Numero = conta;
            Agencia = agencia;

            TotalDeContasCriadas++;
            //Não pode usar this pq TotalDeContasCriadas é uma propriedade da classe e não da instância(static method).
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
