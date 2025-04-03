using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    internal class MediaBLL
    {
        public static void ValidaDados(Aluno aluno)
        {
            Erro.setErro(false);

            if (aluno.P1.Length == 0)
            {
                Erro.setErro("A nota p1 é obrigatória.");
            }
            else
            {
                try
                {
                    float.Parse(aluno.P1);
                }
                catch
                {
                    Erro.setErro("O campo 'p1' só aceita números."); 
                    return;
                }
                if (float.Parse(aluno.P1) < 0)
                {
                    Erro.setErro("o campo 'p1' precisa conter um número maior que 0.");
                }
            }

            if (aluno.P2.Length == 0)
            {
                Erro.setErro("A nota p2 é obrigatória.");
            }
            else
            {
                try
                {
                    float.Parse(aluno.P2);
                }
                catch
                {
                    Erro.setErro("O campo 'p2' só aceita números."); 
                    return;
                }
                if (float.Parse(aluno.P2) < 0)
                {
                    Erro.setErro("o campo 'p2' precisa conter um número maior que 0.");
                }
            }

            if (aluno.P3.Length == 0)
            {
                Erro.setErro("A nota p3 é obrigatória.");
            }
            else
            {
                try
                {
                    float.Parse(aluno.P3);
                }
                catch
                {
                    Erro.setErro("O campo 'p3' só aceita números."); 
                    return;
                }
                if (float.Parse(aluno.P3) < 0)
                {
                    Erro.setErro("o campo 'p3' precisa conter um número maior que 0.");
                }
            }

            if (aluno.P4.Length == 0)
            {
                Erro.setErro("A nota p4 é obrigatória.");
            }
            else
            {
                try
                {
                    float.Parse(aluno.P4);
                }
                catch
                {
                    Erro.setErro("O campo 'p4' só aceita números."); return;
                }
                if (float.Parse(aluno.P4) < 0)
                {
                    Erro.setErro("o campo 'p4' precisa conter um número maior que 0.");
                }
            }
        }
    }
}
