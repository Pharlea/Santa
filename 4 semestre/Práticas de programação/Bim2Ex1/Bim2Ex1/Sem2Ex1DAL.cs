using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Bim2Ex1
{
    internal class Sem2Ex1DAL
    {
        private static String strConexao = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\unisanta\Desktop\Bim2Ex1\BDFarinha.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader result;

        public static void conecta()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                Erro.setMsg("Problemas ao se conectar ao Banco de Dados");
            }

        }

        public static void desconecta()
        {
            conn.Close();
        }

        public static void popularCliente()
        {
            string aux = "select * from TabClientes where cnpj = '" + Cliente.getCNPJ() + "'";

            strSQL = new OleDbCommand(aux, conn);
            result = strSQL.ExecuteReader();
        }

        public static void consultaClientes()
        {

            if (result.Read())
            {
                Cliente.setNome(result.GetString(1));
            }
            else
            {
                Erro.setMsg("CNPJ não cadastrado");
            }
        }

        public static void popular()
        {
            string aux = "select * from TabVendasCliente where cnpj = '" + Cliente.getCNPJ() + "'";

            strSQL = new OleDbCommand(aux, conn);
            result = strSQL.ExecuteReader();
        }

        public static void consultaVendaCliente()
        {
            Erro.setErro(false);
            if (result.Read())
            {
                VendasCliente.setData(result.GetString(2));
                VendasCliente.setToneladas(result.GetString(3));
                VendasCliente.setvalor(result.GetString(4));
            }
            else
            {
                Erro.setErro(true);
            }
        }
    }
}
