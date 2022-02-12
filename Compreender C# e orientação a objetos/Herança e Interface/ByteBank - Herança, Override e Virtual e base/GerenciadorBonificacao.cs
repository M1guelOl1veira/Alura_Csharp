using ByteBank___Herança__Override_e_Virtual_e_base.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank___Herança__Override_e_Virtual_e_base
{
    class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        //Sobrecargas: métodos com o mesmo nome mas com lista de argumentos diferentes.
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
