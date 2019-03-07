using System;
using System.Collections.Generic;
using System.Text;

namespace Refatorando001.after.Readers
{
   abstract class ArquivoReaderBase : IArquivoReader
    {
        protected Layout Layout { get; }

        public ArquivoReaderBase(Layout layout)
        {
            this.Layout = layout;
        }

        public abstract ReaderResult LerArquivo(string caminho);
        
    }
}
