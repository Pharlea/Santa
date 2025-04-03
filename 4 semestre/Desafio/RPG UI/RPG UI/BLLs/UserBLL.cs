using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using RPG_UI.DAL;
using RPG_UI.Models;

namespace RPG_UI.BLLs
{
    internal class UserBLL
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

        public static void verificaSignUp()
        {
            Erro.erro = false;

            if (User.Senha.Length == 0)
            {
                Erro.setMsg("Login ou senha inválidos");
                return;
            }

            if (User.Nome.Length == 0)
            {
                Erro.setMsg("O campo nome é obrigatório");
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

        public static async Task<string> registrarAsync()
        {
            return await HabilidadesDAL.registrarAsync();
        }

        public static async Task<List<User>> GetUsersAsync()
        {
            return await HabilidadesDAL.getUsersAsync();
        }

        public static async Task deleteUserAsync(int id)
        {
            await HabilidadesDAL.deleteUserAsync(id);
        }

        public static async Task<Image> GetImageAsync(string path)
        {
            return await HabilidadesDAL.getImageAsync(path);
        }
    }
}
