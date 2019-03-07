using Refatorando001.after;
using System;

namespace Refatorando001
{
    class Program
    {
        static void Main(string[] args)
        {
            var arquivoInfo = new ArquivoInfo(TipoArquivoEnum.CSV);
            var arquivo = new Arquivo(arquivoInfo);
            var result = arquivo.ProcessarArquivo("sample.csv");
            Console.WriteLine(result.Data);
            Console.Read();
            
        }
    }
}
