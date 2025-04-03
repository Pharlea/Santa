using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP___gerar_pdf_e_ler_lista
{
    internal class LivroBLL
    {
        public static void conecta()
        {
            LivroDAL.conecta();
            if (!Erro.getErro())
            {
                LivroDAL.populaDR();
            }
        }

        public static void desconecta()
        {
            LivroDAL.desconecta();
        }

        public static void getProximo()
        {
            LivroDAL.getProximo();
        }
    }
}
