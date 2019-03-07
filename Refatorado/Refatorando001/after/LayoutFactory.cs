using System;

namespace Refatorando001.after
{
    internal class LayoutFactory
    {
        /*
         * apesar de ter sido uma escolha do editor de código, internal static faz sentido aqui, pois limitamos a criação
         * dos layouts as classe do pacote*/
        internal static Layout Criar(ArquivoInfo arquivoInfo)
        {
            /*
             O código que estava dentro do criarLayout foi movido para cá. A responsabilidade de criação do layout 
             fica por conta desta classe agora. Se necessário criar um novo layout, a rotina pode ser feita aqui, e a 
             classe arquivo não sofrerá alterações.
             */

            /*
            if (arquivoInfo.flagArquivoXLS == ArquivoInfo.FlagArquivoXLS.Nao)
            {
                layoutArquivo = new LayoutTXT(idArquivoLayout);
            }
            else
            {
                layoutArquivo = new LayoutXLS(idArquivoLayout);
            }
            */

            var result = new Layout()
            {
                Separador = (arquivoInfo.TipoArquivo == TipoArquivoEnum.CSV ? "," : string.Empty)
            };

            return result;


        }
    }
}