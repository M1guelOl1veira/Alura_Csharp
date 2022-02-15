using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    //A classe ParceiroComercial não faz parte do funcionários
    //e precisar também ser autenticada, para isso criou-se o 
    //essa interface, chamada também de contrato.
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
