using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Newtonsoft.Json;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace PraticasDeProgramacao_Desafio_Bim01
{
    internal class DAL
    {
        private static string strConexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:BDpessoas.accdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader result;
        private static String aux;
        

        public static void lerDados()
        {
            using (var conn = new OleDbConnection(strConexao))
            {
                try
                {
                    conn.Open();
                    string aux = "select * from TabPessoas where id = " + Pessoa.id;
                    using (var cmd = new OleDbCommand(aux, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Pessoa.nome = reader.GetString(1);
                                Pessoa.telefone = reader.GetString(2);
                                Pessoa.eMail = reader.GetString(3);
                                Pessoa.cep = reader.GetString(4);
                                Pessoa.estado = reader.GetString(5);
                                Pessoa.cidade = reader.GetString(6);
                                Pessoa.bairro = reader.GetString(7);
                                Pessoa.rua = reader.GetString(8);
                                Pessoa.numero = reader.GetString(9);
                                Pessoa.complemento = reader.GetString(10);
                            }
                            else
                            {
                                Erro.Erro.setMsg("id não encontrado");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Erro.Erro.setMsg("Erro ao ler dados: " + ex.Message);
                }
            }
        }

        public static void registraPessoa()
        {
            string aux = "insert into TabPessoas(id, nome, telefone, email, cep, estado, cidade, bairro, rua, numero, complemento) values (@id, @nome, @telefone, @email, @cep, @estado, @cidade, @bairro, @rua, @numero, @complemento)";
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Erro.Erro.setMsg("Erro ao conectar com banco de dados: " + e);
                return;
            }

            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@id", OleDbType.Integer).Value = Pessoa.id;
            strSQL.Parameters.Add("@nome", OleDbType.VarChar).Value = Pessoa.nome;
            strSQL.Parameters.Add("@telefone", OleDbType.VarChar).Value = Pessoa.telefone;
            strSQL.Parameters.Add("@email", OleDbType.VarChar).Value = Pessoa.eMail;
            strSQL.Parameters.Add("@cep", OleDbType.VarChar).Value = Pessoa.cep;
            strSQL.Parameters.Add("@estado", OleDbType.VarChar).Value = Pessoa.estado;
            strSQL.Parameters.Add("@cidade", OleDbType.VarChar).Value = Pessoa.cidade;
            strSQL.Parameters.Add("@bairro", OleDbType.VarChar).Value = Pessoa.bairro;
            strSQL.Parameters.Add("@rua", OleDbType.VarChar).Value = Pessoa.rua;
            strSQL.Parameters.Add("@numero", OleDbType.VarChar).Value = Pessoa.numero;
            strSQL.Parameters.Add("@complemento", OleDbType.VarChar).Value = Pessoa.complemento;
            try
            {
                strSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Erro.Erro.setMsg("não foi possível gravar os dados: " + ex);
                conn.Close();
                return;
            }
            conn.Close();
        }

        public static void deletaPessoa()
        {
            string aux = "delete from TabPessoas where id = " + Pessoa.id;

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Erro.Erro.setMsg("Erro ao conectar com banco de dados: " + e);
                return;
            }

            strSQL = new OleDbCommand(aux, conn);
            try
            {
                int linhasAfetadas = strSQL.ExecuteNonQuery();
                if (linhasAfetadas == 0) { Erro.Erro.setMsg("Id não existente"); }
            }
            catch (Exception ex)
            {
                Erro.Erro.setMsg("não foi possível deletar os dados: " + ex);
                conn.Close();
                return;
            }

            conn.Close();
        }

        public static void editarPessoa()
        {
            string aux = "update TabPessoas set nome = @nome, telefone = @telefone, email = @email, cep = @cep, estado = @estado, cidade = @cidade, bairro = @bairro, rua = @rua, numero = @numero, complemento = @complemento where id = " + Pessoa.id;

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Erro.Erro.setMsg("Erro ao conectar com banco de dados: " + e);
                return;
            }

            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@nome", OleDbType.VarChar).Value = Pessoa.nome;
            strSQL.Parameters.Add("@telefone", OleDbType.VarChar).Value = Pessoa.telefone;
            strSQL.Parameters.Add("@email", OleDbType.VarChar).Value = Pessoa.eMail;
            strSQL.Parameters.Add("@cep", OleDbType.VarChar).Value = Pessoa.cep;
            strSQL.Parameters.Add("@estado", OleDbType.VarChar).Value = Pessoa.estado;
            strSQL.Parameters.Add("@cidade", OleDbType.VarChar).Value = Pessoa.cidade;
            strSQL.Parameters.Add("@bairro", OleDbType.VarChar).Value = Pessoa.bairro;
            strSQL.Parameters.Add("@rua", OleDbType.VarChar).Value = Pessoa.rua;
            strSQL.Parameters.Add("@numero", OleDbType.VarChar).Value = Pessoa.numero;
            strSQL.Parameters.Add("@complemento", OleDbType.VarChar).Value = Pessoa.complemento;
            try
            {
                strSQL.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Erro.Erro.setMsg("não foi possível editar os dados: " + ex);
                conn.Close();
                return;
            }
            conn.Close();
        }

        public static async Task buscarEnderecoAsync(string cep)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://viacep.com.br/ws/{cep}/json/";
                HttpResponseMessage response = await client.GetAsync(url);
                
                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    Endereco endereco = JsonConvert.DeserializeObject<Endereco>(jsonResponse);
                    
                    Pessoa.rua = endereco.logradouro;
                    Pessoa.cidade = endereco.localidade;
                    Pessoa.bairro = endereco.bairro;
                    Pessoa.estado = endereco.estado;
                }
                else
                {
                    Erro.Erro.setMsg("Não foi possível encontrar o cep requisitado.");
                    return;
                }
            }
        }
    }
    
}
