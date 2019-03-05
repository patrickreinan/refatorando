using Refatorando001.after.Readers;

namespace Refatorando001.after
{
    internal interface IArquivoReader
    {
        ReaderResult LerArquivo(string caminho);
    }
}