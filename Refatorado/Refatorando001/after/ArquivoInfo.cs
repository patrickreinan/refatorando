namespace Refatorando001.after
{
    internal enum TipoArquivoEnum
    {
        CSV,
        XLS          
    }

    internal class ArquivoInfo
    {
        public ArquivoInfo(TipoArquivoEnum tipoArquivo)
        {
            TipoArquivo = tipoArquivo;
        }

        public TipoArquivoEnum TipoArquivo { get; }
    }



}