namespace Refatorando001.after.Readers
{
    class ArquivoXLSReader : ArquivoReaderBase
    {
        public ArquivoXLSReader(Layout layout) : base(layout)
        {
        }

        public override ReaderResult LerArquivo(string caminho)
        {
            //a rotina do arquivo XLS vem para cá
            /*
              string conexao = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 Xml;HDR=YES';", CaminhoArquivo);

            //Assumindo-se que Arquivo XLS possui somente layoutPrincipal, sem a utilização de cabeçalho e rodapé
            OleDbConnection conexaoXLS = new OleDbConnection(conexao);
            OleDbCommand command = new OleDbCommand();
            OleDbDataAdapter oDataAdapter = new OleDbDataAdapter();
            DataTable oDtFillResult = new DataTable();

            try
            {
                conexaoXLS.Open();

                DataTable dtExcelSchema;
                dtExcelSchema = conexaoXLS.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string SheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();


                command.CommandType = System.Data.CommandType.Text;
                command.Connection = conexaoXLS;
                command.CommandText = String.Format("Select * from [{0}]", SheetName);
                oDataAdapter.SelectCommand = command;
                oDataAdapter.Fill(oDtFillResult);
                this.LayoutArquivo = new Layout();
                LayoutArquivo.DtRetornoGenerico1 = new DataTable();
                LayoutArquivo.DtRetornoGenerico1 = oDtFillResult;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                command.Dispose();
                conexaoXLS.Close();
                oDataAdapter.Dispose();
                oDtFillResult.Dispose();
            }
            */

            /*retorna um reader result com os dados*/
            return new ReaderResult(null, null);
        }

        
    }
}
