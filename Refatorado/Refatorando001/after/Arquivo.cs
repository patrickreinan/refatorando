using Refatorando001.after.Readers;
using System;
using System.Collections.Generic;

namespace Refatorando001.after
{
    class Arquivo
    {

        #region " Observações "
        /* Arquivo info nem precisa ser armazenado, pois é utilizado somente no construtor.
        public ArquivoInfo ArquivoInfo { get;  } 
        */
        /* Esta propriedade não está sendo utilizada em nenhum ponto do código 
    public Dictionary<Object, Object> Alvo { get; }*/
        /* Esta propriedade não está sendo utilizada em nenhum ponto do código 
        public String TipoArquivoIdentificador { get; set; } */

        #endregion

            
        /* O LayoutArquivo é escrito somente dentro da classe Arquivo, logo ele pode ser private set */
        public Layout LayoutArquivo { get; private set; }

        /*Uma nova interface foi criada para separar a leitura dos arquivos da rotina principal. 
         * Está como um campo, pois não será exposta para fora da classe.
         */
        private readonly IArquivoReader reader;

        public Arquivo(ArquivoInfo arquivoInfo)
        {
            LayoutArquivo = LayoutFactory.Criar(arquivoInfo);
            reader = ArquivoReaderFactory.Criar(arquivoInfo);
        }

        /* Agora a leitura do arquivo independe do layout ou tipo de arquivo. Quando a classe é instanciada,
         * o reader é criado com base no arquivoInfo.
         */
        public ReaderResult ProcessarArquivo(string caminho)
        {
            return reader.LerArquivo(caminho);
        }


    }
}
