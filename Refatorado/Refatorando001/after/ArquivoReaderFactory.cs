using Refatorando001.after.Readers;
using System;

namespace Refatorando001.after
{
    internal class ArquivoReaderFactory
    {
        internal static IArquivoReader Criar(ArquivoInfo arquivoInfo)
        {
            switch (arquivoInfo.TipoArquivo)
            {
                case TipoArquivoEnum.CSV: return new ArquivoCSVReader();
                case TipoArquivoEnum.XLS: return new ArquivoXLSReader();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}