using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // IO = Input e Output


namespace ByteBankImportacaoExportacao 
{
    /*Para não termos um arquivo de código gigante e difícil de encontrar o que queremos, estamos dividindo a 
     * classe Program em vários arquivos com o modificador partial.
     * Costuma ser uma má prática, mas é utilizado quando temos programas que geram código*/
    partial class Program 
    { 
        static void Main(string[] args) 
        {
            var enderecoDoArquivo = "contas.txt";

            //Sixtaxe de 2 using encadeados.
            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    /*Perceba que apesar do retorno de Read ser um char do arquivo, seu tipo de retorno é int 
                     * e não byte ou char. Isto é porque o método retorna -1 quando o fim do stream foi 
                     * atingido. */
                    Console.WriteLine(linha);
                } 
            }
            


            Console.ReadLine();
        }

        

    }
} 
 