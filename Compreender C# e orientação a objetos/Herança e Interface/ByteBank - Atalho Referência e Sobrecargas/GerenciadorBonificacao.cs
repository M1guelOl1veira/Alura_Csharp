using ByteBank___Atalho_Referência_e_Sobrecargas.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank___Atalho_Referência_e_Sobrecargas
{
    class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        //Sobrecargas: métodos com o mesmo nome mas com lista de argumentos diferentes.
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public void Registrar(Diretor  diretor)
        {
            _totalBonificacao += diretor.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
