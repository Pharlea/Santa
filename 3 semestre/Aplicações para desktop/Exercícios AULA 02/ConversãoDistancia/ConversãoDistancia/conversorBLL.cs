using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversãoDistancia
{
    internal class conversorBLL
    {
        public static void ValidaDados (Conversor conversor)
        {
            Erro.setErro(false);
            if (conversor.valor.Length == 0)
            {
                Erro.setErro("O campo de valor é obrigatório");
                return;
            }
            else
            {
                try
                {
                    float.Parse(conversor.valor);
                }
                catch
                {
                    Erro.setErro("O valor deve ser numérico");
                    return ;
                }
                if (float.Parse(conversor.valor) < 0)
                {
                    Erro.setErro("O valor deve ser maior que 0");
                    return;
                }
            }
        }
    }
}
