using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void EscritaBinaria()
        {
            /* O BinaryWriter possui construtores com argumentos de encoding, mas o encoding é utilizado 
             * apenas no momento da escrita dechar e string.
             * Se não é necessário mantermos um arquivo com texto legível, podemos criar este documento 
             * escrevendo os valores em formato binário! Para tal, começamos com o stream de arquivo e 
             * um Writer diferente, o BinaryWriter*/
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(456); // Número da Agência
                escritor.Write(546544); // Número da conta
                escritor.Write(4000.50); // Saldo
                escritor.Write("Gustavo Braga");
            }
        }

        static void LeituraBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numeroConta = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var titular = leitor.ReadString();

                Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo}");
            }
        }

    }
}
