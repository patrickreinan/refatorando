/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EProtesto2.Model;
using EProtesto2.BLL;
using System.Data;
using System.IO;
using System.Data.OleDb;

namespace EProtesto2File
{
    public class Arquivo
    {
        private ArquivoInfo arquivoInfo;
        public ArquivoInfo ArquivoInfo
        {
            get { return arquivoInfo; }
            set { arquivoInfo = value; }
        }

        private Layout layoutArquivo;
        public Layout LayoutArquivo
        {
            get { return layoutArquivo; }
            set { layoutArquivo = value; }
        }

        private Dictionary<Object, Object> alvo;
        public Dictionary<Object, Object> Alvo
        {
            get { return alvo; }
            set { alvo = value; }
        }

        private String tipoArquivoIdentificador;
        public String TipoArquivoIdentificador
        {
            get
            {
                return tipoArquivoIdentificador;
            }
            set
            {
                tipoArquivoIdentificador = value;
            }
        }

        public Arquivo(ArquivoInfo arquivoInfo)
        {
            this.arquivoInfo = arquivoInfo;
            this.alvo = new Dictionary<Object, Object>();
            criaLayout(arquivoInfo.IdArquivoLayout);
        }

        public Arquivo()
        {

        }


        private void criaLayout(Int64 idArquivoLayout)
        {
            if (arquivoInfo.flagArquivoXLS == ArquivoInfo.FlagArquivoXLS.Nao)
            {
                layoutArquivo = new LayoutTXT(idArquivoLayout);
            }
            else
            {
                layoutArquivo = new LayoutXLS(idArquivoLayout);
            }
        }

        public void lerArquivo()
        {
            layoutArquivo.lerArquivo(this);
        }

        public void lerArquivoCSV()
        {
            layoutArquivo.lerArquivoCSV(this);
        }

        public void lerArquivoCSV(String CaminhoArquivo)
        {
            if (CaminhoArquivo.EndsWith(".csv"))
            {
                string FileName = CaminhoArquivo;
                OleDbConnection conn = new OleDbConnection(String.Format("Provider=Microsoft.Jet.OleDb.4.0; Data Source = {0}; Extended Properties = \"Text;HDR=YES;FMT=Delimited\"", Path.GetDirectoryName(FileName)));

                conn.Open();

                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM " + Path.GetFileName(FileName), conn);

                DataSet dataSet = new DataSet("Temp");
                adapter.Fill(dataSet);
                conn.Close();
            }
        }

        //public void lerArquivo(string CaminhoArquivo)
        //{
        //    layoutArquivo.lerArquivo(CaminhoArquivo);
        //}        

        public void lerArquivo(String CaminhoArquivo)
        {
            string conexao = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0 Xml;HDR=YES';", CaminhoArquivo);
            DataTable dt;

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


        }

        public void escreverArquivo(int TypeRow)
        {
            layoutArquivo.escreveArquivo(this, TypeRow);
        }
    }
}
*/