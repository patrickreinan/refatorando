using System;
using System.IO;

namespace Refatorando001.after.Readers
{
    class ArquivoCSVReader : IArquivoReader
    {
        public ReaderResult LerArquivo(string caminho)
        {

            /*
             * A rotina do arquivo CSV vem para cá
            var conn = new OleDbConnection(String.Format("Provider=Microsoft.Jet.OleDb.4.0; Data Source = {0}; Extended Properties = \"Text;HDR=YES;FMT=Delimited\"", Path.GetDirectoryName(FileName)));
            var adapter = new OleDbDataAdapter("SELECT * FROM " + Path.GetFileName(caminho), conn);
            var dataSet = new DataSet("Temp");
            adapter.Fill(dataSet);
            conn.Close();
            */

            /*retorna um reader result com os dados*/
            return new ReaderResult();

        }
    }
}
