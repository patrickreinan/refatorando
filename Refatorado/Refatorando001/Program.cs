using Refatorando001.after;
using System;

namespace Refatorando001
{
    class Program
    {
        static void Main(string[] args)
        {
            LerArquivoCSV("sample.csv");
        }

        static void LerArquivo(string nomeArquivo, TipoArquivoEnum tipo)
        {
            var arquivoInfo = new ArquivoInfo(tipo);
            var arquivo = new Arquivo(arquivoInfo);
            var result = arquivo.ProcessarArquivo(nomeArquivo);
            Console.WriteLine(result.Data);
            Console.Read();
        }


        static void LerArquivoXLS(string nomeArquivo)
        {
            LerArquivo(nomeArquivo, TipoArquivoEnum.XLS);
        }

        static void LerArquivoCSV(string nomeArquivo)
        {
            LerArquivo(nomeArquivo, TipoArquivoEnum.CSV);

        }
    }
}
