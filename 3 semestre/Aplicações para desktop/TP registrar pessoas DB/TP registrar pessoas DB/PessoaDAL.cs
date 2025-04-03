using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace TP_registrar_pessoas_DB
{
    internal class PessoaDAL
    {
        private static string strConexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDAulas.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader result;
        public static void conecta ()
        {
            try
            {
                conn.Open ();
            }
            catch (Exception)
            {
                Erro.setMsg("Falha em conectar com o servidor de dados");
            }
        }

        public static void desconecta ()
        {
            conn.Close ();
        }

        public static void registraPessoa (Pessoa _pessoa)
        {
            string aux = "insert into TabPessoa(codigo, nome, sexo, idade) values (@codigo, @nome, @sexo, @idade)";
            strSQL = new OleDbCommand (aux, conn);

            strSQL.Parameters.Add("@codigo", OleDbType.VarChar).Value = _pessoa.codigo;
            strSQL.Parameters.Add("@nome", OleDbType.VarChar).Value = _pessoa.nome;
            strSQL.Parameters.Add("@sexo", OleDbType.VarChar).Value = _pessoa.sexo;
            strSQL.Parameters.Add("@idade", OleDbType.VarChar).Value = _pessoa.idade;
            strSQL.ExecuteNonQuery ();
        }

        public static void lerRegistroPessoa (Pessoa _pessoa)
        {
            string aux = "select * from TabPessoa where codigo = @codigo";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@codigo", OleDbType.VarChar).Value= _pessoa.codigo;

            result = strSQL.ExecuteReader ();
            Erro.setErro(false);
            if (result.Read())
            {
                _pessoa.nome = result.GetString(1);
                _pessoa.sexo = result.GetString(2);
                _pessoa.idade = result.GetString(3);
            }
            else
            {
                Erro.setMsg("Pessoa não cadastrada");
            }
        }

        private void cadPessoa_Load(object sender, EventArgs e)
        {

        }
    }
}
