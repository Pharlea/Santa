using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bim2Ex1
{
    internal class Sem2Ex1BLL
    {
        public static void conecta()
        {
            Sem2Ex1DAL.conecta();
        }

        public static void popularVenda()
        {
            Sem2Ex1DAL.popularVenda();
        }

        public static void popularCliente()
        {
            Sem2Ex1DAL.popularCliente();
        }

        public static void consultaClientes()
        {
            Sem2Ex1DAL.consultaClientes();
        }

        public static void consultaVendaCliente()
        {
            Sem2Ex1DAL.consultaVendaCliente();
        }

        public static void desconecta()
        {
            Sem2Ex1DAL.desconecta();
        }

        public static bool isValidoCNPJ(String _cnpj)
        {
            return true;
        }

        public static void validaCNPJ()
        {
            Erro.setErro(false);
            if (Cliente.getCNPJ().Equals(""))
            {
                Erro.setMsg("O código é de preenchimento obrigatório!");
                return;
            }
            if (!isValidoCNPJ(Cliente.getCNPJ()))
            {
                Erro.setMsg("O CNPJ digitado não é válido!");
                return;
            }
        }
    }
}
