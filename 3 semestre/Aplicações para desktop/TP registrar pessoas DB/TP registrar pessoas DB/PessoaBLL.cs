using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_registrar_pessoas_DB
{
    internal class PessoaBLL
    {
        public static void conecta()
        {
            PessoaDAL.conecta();
        }
        public static void desconecta()
        {
            PessoaDAL.desconecta();
        }

        public static void verificaDados (Pessoa _pessoa)
        {
            Erro.setErro(false);
            if (_pessoa.codigo == "")
            {
                Erro.setMsg("O campo de código é obrigatório");
                return;
            }
            try
            {
                int.Parse(_pessoa.codigo);
            }
            catch
            {
                Erro.setMsg("O campo de código precisa ser um número inteiro positivo");
                return;
            }
            if (int.Parse(_pessoa.codigo) < 0)
            {
                Erro.setMsg("O campo de código precisa ser um número inteiro positivo");
                return;
            }

            if (_pessoa.nome == "")
            {
                Erro.setMsg("O campo de nome é obrigatório");
                return;
            }

            if (_pessoa.sexo == "")
            {
                Erro.setMsg("O campo de sexo é obrigatório");
                return;
            }

            if (int.Parse(_pessoa.idade) <= 0)
            {
                Erro.setMsg("O campo de idade deve ser maior que 0");
                return;
            }

            PessoaDAL.registraPessoa(_pessoa);
        }

        public static void verificaCodigo (Pessoa _pessoa)
        {
            Erro.setErro(false);
            if (_pessoa.codigo == "")
            {
                Erro.setMsg("O campo de código é obrigatório");
                return;
            }
            try
            {
                int.Parse(_pessoa.codigo);
            }
            catch
            {
                Erro.setMsg("O campo de código precisa ser um número inteiro positivo");
                return;
            }
            if (int.Parse(_pessoa.codigo) < 0)
            {
                Erro.setMsg("O campo de código precisa ser um número inteiro positivo");
                return;
            }

            PessoaDAL.lerRegistroPessoa (_pessoa);
        }
    }
}
