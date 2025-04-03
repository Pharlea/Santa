using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_UI
{
    internal class Erro
    {
        public static bool erro {  get; set; }
        public static string msg { get; set; }

        public static void setMsg(string _msg)
        {
            erro = true;
            msg = _msg;
        }        
    }
}
