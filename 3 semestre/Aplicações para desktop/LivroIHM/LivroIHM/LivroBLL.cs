using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroIHM
{
    internal class LivroBLL
    {
        public void validaDados(Livro livro)
        {
            if (livro.getTitulo.Length == 0)
            {
                Erro.setErro("O campo de título deve ser preenchido");
                return;
            }

            if (livro.getAutor.Length == 0)
            {
                Erro.setErro("O campo de título deve ser preenchido");
                return;
            }

            if (livro.getEditora.Length == 0)
            {
                Erro.setErro("O campo de título deve ser preenchido");
                return;
            }

            if (livro.getAnoedicao.Length == 0)
            {
                Erro.setErro("O campo de título deve ser preenchido");
                return;
            }
            else
            {
                try
                {
                    float.Parse(livro.getAnoedicao);
                }
                catch
                {
                    Erro.setErro("O campo de ano deve ser numérico");
                    return;
                }
                if (float.Parse(livro.getAnoedicao) < 0)
                {
                    Erro.setErro("o campo de ano deve não pode ser preenchido com números negativos");
                }
            }

            if (livro.getLocal.Length == 0)
            {
                Erro.setErro("O campo de título deve ser preenchido");
                return;
            }
        }
    }
}
