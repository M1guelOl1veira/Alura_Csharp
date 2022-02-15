using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        //Tornar uma classe ou método abstract não permite instanciá-lo diretamente
        //somente através de suas classes derivadas.
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        //A visibilidade do protected só permite que o atributo seja
        //alterado dentro da classe base e suas derivadas.
        public double Salario { get; protected set; }

        //Construtores da classe base são invocados
        //primeiro que os construtores das classes derivadas.
        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        //Método abstrato.
        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}
