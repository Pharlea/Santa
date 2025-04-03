using System.Text.RegularExpressions;
using System.Threading.Tasks;
using RPG_UI.DAL;
using RPG_UI.Models;

namespace RPG_UI.BLLs
{
    internal class LoginBLL
    {
        public static void verificaLogin()
        {
            Erro.erro = false;

            if (User.Senha.Length == 0)
            {
                Erro.setMsg("Login ou senha inválidos");
                return;
            }

            if (User.Email.Length == 0)
            {
                Erro.setMsg("Login ou senha inválidos");
                return;
            }

            if (!Regex.IsMatch(User.Email, "[a-zA-Z0-9]@(gmail|hotmail).com$"))
            {
                Erro.setMsg("Login ou senha inválidos");
                return;
            }
        }

        public async static Task getLoginAsync ()
        {
            await HabilidadesDAL.getLoginAsync();
        }

        public static async Task getUser()
        {
            await HabilidadesDAL.getUser();
        }
    }
}
