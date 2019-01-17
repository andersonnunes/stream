using System;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            CriarArquivoComWriter();
            Console.WriteLine("Aplicação finalizada ...");

            Console.ReadKey();
        }
    }
}
