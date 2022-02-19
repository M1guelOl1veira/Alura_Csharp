using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        //Toda classe é derivada de object implicitamente.
        public override bool Equals(object obj)
        {
            //Cliente outroCliente = (Cliente)obj; - Outra maneira de conversão.
            //É necessário converter obj para a classe cliente para acessar os parâmetros da classe cliente e depois compará-los.
            //Essa maneira é chamada de cast.
            Cliente outroCliente = obj as Cliente;

            //Isso é feito pq caso o parâmetro passado não seja do tipo cliente a variável outroCliente irá ficar sem referência.
            if (outroCliente == null)
            {
                return false;
            }

            //Podemos comparar todos os atributos ou apenas os identificadores, como feito abaixo.
            return CPF == outroCliente.CPF;
        }
    }
}
