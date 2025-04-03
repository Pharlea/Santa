using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace TP___gerar_pdf_e_ler_lista
{
    internal class LivroDAL
    {
        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDLivros.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbDataAdapter adaptador;
        private static DataTable dt = new DataTable();
        private static int i = -1;

        public static DataTable getDt ()
        {
            return dt;
        }

        public static void voltaI ()
        {
            i = -1;
        }
        public static void conecta()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                Erro.setMsg("Banco da Dados não localizado - contacte o suporte.");
            }
        }

        public static void desconecta()
        {
            conn.Close();
        }


        public static void populaDR()
        {
            String aux = "select * from TabLivro";

            adaptador = new OleDbDataAdapter(aux, conn);
            adaptador.Fill(dt);
            adaptador.Dispose();
        }

        public static void getProximo()
        {
            Erro.setErro(false);
            ++i;
            if (i >= dt.Rows.Count)
            {
                Erro.setErro(true);
                i = -1;
            }
            else
            {
                Livro.codigo = "" + dt.Rows[i].ItemArray[0];
                Livro.titulo = "" + dt.Rows[i].ItemArray[1];
                Livro.autor = "" + dt.Rows[i].ItemArray[2];
                Livro.editora = "" + dt.Rows[i].ItemArray[3];
                Livro.ano = "" + dt.Rows[i].ItemArray[4];
            }
        }

    }
}
