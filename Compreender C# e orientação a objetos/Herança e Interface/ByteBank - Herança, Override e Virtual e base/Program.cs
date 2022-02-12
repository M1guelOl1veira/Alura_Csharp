using ByteBank___Herança__Override_e_Virtual_e_base.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank___Herança__Override_e_Virtual_e_base
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Diretor miguel = new Diretor();
            miguel.Nome = "Miguel";
            miguel.CPF = "15485265945";
            miguel.Salario = 5000;

            Funcionario pedro = new Funcionario();
            pedro.Nome = "Pedro";
            pedro.CPF = "5241235248";
            pedro.Salario = 2000;

            Console.WriteLine(miguel.Nome);
            Console.WriteLine(miguel.GetBonificacao());

            Console.WriteLine(pedro.Nome);
            Console.WriteLine(pedro.GetBonificacao());

            gerenciador.Registrar(miguel);
            gerenciador.Registrar(pedro);
            gerenciador.GetTotalBonificacao();

            Console.WriteLine(gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
