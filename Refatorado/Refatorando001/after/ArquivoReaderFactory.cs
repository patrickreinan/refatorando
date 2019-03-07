using Refatorando001.after.Readers;
using System;

namespace Refatorando001.after
{
    internal class ArquivoReaderFactory
    {
        internal static IArquivoReader Criar(ArquivoInfo arquivoInfo)
        {

            var layout = LayoutFactory.Criar(arquivoInfo);

            switch (arquivoInfo.TipoArquivo)
            {
                case TipoArquivoEnum.CSV: return new ArquivoCSVReader(layout);
                case TipoArquivoEnum.XLS: return new ArquivoXLSReader(layout);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}