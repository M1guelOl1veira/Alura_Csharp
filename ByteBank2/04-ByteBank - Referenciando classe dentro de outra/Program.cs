using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank___Referenciando_classe_dentro_de_outra
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente Conta = new ContaCorrente();
            Conta.titular = new Cliente();

            Conta.titular.nome = "João";
            Conta.titular.cpf = "12342354842";
            Conta.titular.profissao = "Dev";

            Console.WriteLine(Conta.titular.nome);
            Console.WriteLine(Conta.titular.cpf);
            Console.WriteLine(Conta.titular.profissao);

            Console.ReadLine();
        }
    }
}
