using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //Herança permite derivar classes de uma base.
    public class Diretor : Funcionario
    {
        //override permite sobrescrever a lógica de um método.
        public override double GetBonificacao()
        {
            //base permite a fazer referência do método da classe base.
            return Salario + base.GetBonificacao();
        }
    }
}
