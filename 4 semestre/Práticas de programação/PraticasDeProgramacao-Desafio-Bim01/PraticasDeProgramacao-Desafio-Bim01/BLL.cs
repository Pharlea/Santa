using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Erro;


namespace PraticasDeProgramacao_Desafio_Bim01
{
    internal class BLL
    {
        public static void validaDados (string temp)
        {
            Erro.Erro.setErro(false);
            //teste do id
            if (!int.TryParse(temp, out int num)) { Erro.Erro.setMsg("O campo de id é obrigatório"); return; }
            else { Pessoa.id = num; }
            if (Pessoa.id < 0) { Erro.Erro.setMsg("id inválido"); return; }

            //teste do nome
            if (Pessoa.nome.Length  == 0) { Erro.Erro.setMsg("O campo de nome é obrigatório"); return; }

            //teste do telefone
            if (Pessoa.telefone.Length == 0) { Erro.Erro.setMsg("O campo de telefone é obrigatório"); return; }
            if (!Regex.IsMatch(Pessoa.telefone, @"(^[(][0-9]{2}[)]\s[9][0-9]{4}-[0-9]{4}$)")) { Erro.Erro.setMsg("número de telefone deve seguir o formato '(XX) 9XXXX-XXXXX'"); return; }

            //teste do email
            if (Pessoa.eMail.Length == 0) { Erro.Erro.setMsg("O campo de E-mail é obrigatório"); return; }
            if (!Regex.IsMatch(Pessoa.eMail, @"(\d|\D)[@](gmail|hotmail|)[.]com$")) { Erro.Erro.setMsg("Formato de E-mail não reconhecido."); return; }

            //teste do cep
            if (Pessoa.cep.Length == 0) { Erro.Erro.setMsg("O campo de CEP é obrigatório"); return; }
            if (!Regex.IsMatch(Pessoa.cep, "[0-9]{8}")) { Erro.Erro.setMsg("O campo CEP deve seguir o formato 'XXXXXXXX'"); return; }

            //teste de numero
            if (Pessoa.numero.Length == 0) { Erro.Erro.setMsg("O campo de numero é obrigatório"); return; }
            try
            {
                int.Parse(Pessoa.numero);
            }
            catch
            {
                Erro.Erro.setMsg("número inválido");
                return;
            }
            if (int.Parse(Pessoa.numero) < 0) { Erro.Erro.setMsg("número inválido"); return; }
        }

        public static void validaId(string temp)
        {
            Erro.Erro.setErro(false);
            //teste do id
            if (!int.TryParse(temp, out int num)) { Erro.Erro.setMsg("O campo de id é obrigatório"); return; }
            else { Pessoa.id = num; }
            if (Pessoa.id < 0) { Erro.Erro.setMsg("id inválido"); return; }
        }

        public static bool validaCep(string cep)
        {
            if (cep.Length == 0) { return false; }
            if (!Regex.IsMatch(cep, "[0-9]{8}")) { return false; }
            return true;
        }

        public static void removeValores()
        {
            Pessoa.id = null;
            Pessoa.nome = null;
            Pessoa.telefone = null;
            Pessoa.eMail = null;
            Pessoa.cep = null;
            Pessoa.estado = null;
            Pessoa.cidade = null;
            Pessoa.bairro = null;
            Pessoa.rua = null;
            Pessoa.numero = null;
            Pessoa.complemento = null;
        }

        public static void lerDados()
        {
            DAL.lerDados();
        }

        public static async Task buscarEnderecoAsync(string cep)
        {
            await DAL.buscarEnderecoAsync(cep);
        }

        public static void registraPessoa()
        {
            DAL.registraPessoa();
        }

        public static void deletaPessoa()
        {
            DAL.deletaPessoa();
        }

        public static void editarPessoa()
        {
            DAL.editarPessoa();
        }
    }
}
