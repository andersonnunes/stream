using System;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var enderecoDoArquivo = "contas.txt";

            using(var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using(var leitor = new StreamReader(fluxoDoArquivo))
            {

                while(!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    Console.WriteLine(linha);
                }
            }

            Console.ReadKey();
        }
    }
}
