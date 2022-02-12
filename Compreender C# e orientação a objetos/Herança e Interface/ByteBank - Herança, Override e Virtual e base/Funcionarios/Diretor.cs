using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank___Herança__Override_e_Virtual_e_base.Funcionarios
{
    class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}
