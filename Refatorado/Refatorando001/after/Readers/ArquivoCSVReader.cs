using System;
using System.IO;
using System.Text;

namespace Refatorando001.after.Readers
{
    class ArquivoCSVReader : ArquivoReaderBase
    {
        public ArquivoCSVReader(Layout layout) : base(layout)
        {
        }

        public override ReaderResult LerArquivo(string caminho)
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


            /*fake somente para demonstração...*/
            var linhas = File.ReadAllLines(caminho);
            var builder = new StringBuilder();
            foreach(var linha in linhas)
            {
                var dados = linha.Split(Layout.Separador);
                builder.AppendLine($"{dados[0]} - {dados[1]}");
            }

            return new ReaderResult("Sucesso", builder.ToString() );

        }


    }
}
