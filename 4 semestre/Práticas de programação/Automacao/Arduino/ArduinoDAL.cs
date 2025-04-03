using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Arduino
{
    internal class ArduinoDAL
    {
        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BD.mdb";
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

        public static void insereLog()
        {
            string aux = "insert into TabLog(dispositivo, operacao, data, hora) values ('" + Log.dispositivo + "','" + Log.operacao + "','" + Log.data + "','" + Log.hora + "')";

            strSQL = new OleDbCommand(aux, conn);
            strSQL.ExecuteNonQuery();
        }
    }
}
