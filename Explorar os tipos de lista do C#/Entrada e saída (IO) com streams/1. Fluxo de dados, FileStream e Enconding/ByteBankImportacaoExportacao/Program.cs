using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // IO = Input e Output


namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {
            var enderecoDoArquivo = "contas.txt";

            // Stream = exibicação genérica de um sequência de bytes.
            //Fornece uma stream para um arquivo, dando suporte a operações de leitura e gravação.
            var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

            //Utilizado para guardar um pequeno trecho do arquivo do arquivo temporariamente na memória RAM.
            var buffer = new byte[1024]; // 1 kb
            var numeroDeBytesLidos = -1;

            while(numeroDeBytesLidos != 0)
            {
                //Passamos buffer como argumento, dizemos qual índice ele começa a gravar e quantos bytes
                //no máximo ele pode gravar.
                //Método read retorna um inteiro, quando é retornado 0 quer dizer que não há mais nada a ser lido.
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }

            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            //Encoding - decodificação dos bytes do buffer.
            //Default é o padrão do sistema operacional e o arquivo lido também foi criado nesse mesmo SO
            //logo o enconding é o mesmo.
            var utf8 = Encoding.Default;

            var texto = utf8.GetString(buffer);
            Console.Write(texto);

            //foreach (var meuByte in buffer)
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }

    }
} 
 