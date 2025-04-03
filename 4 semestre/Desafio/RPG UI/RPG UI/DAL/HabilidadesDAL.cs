using System;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using RPG_UI.Models;
using Newtonsoft.Json;
using RPG_UI.ViewModels;
using System.Net.Http.Headers;
using System.Collections.Generic;
using static RPG_UI.ViewModels.UserViewModel;
using System.IO;
using System.Drawing;

namespace RPG_UI.DAL
{

    internal class HabilidadesDAL
    {
        private static string url = "http://localhost:5048";

        /*
            Area das accounts 
        */

        public static async Task getLoginAsync()
        {
            TokenManager manager = new TokenManager();
            Erro.erro = false;
            string route = "/account/login";

            loginViewModel model = new UserViewModel.loginViewModel();
            model.Email = User.Email;
            model.Password = User.Senha;

            using (var client = new HttpClient())
            {
                var endPoint = new Uri(url + route);

                var jsonUser = JsonConvert.SerializeObject(model);
                var payload = new StringContent(jsonUser, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync(endPoint, payload);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        Token token = JsonConvert.DeserializeObject<Token>(content);
                        manager.SaveToken(token);
                    }
                    else
                    {
                        Erro.setMsg(response.ReasonPhrase);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    Erro.setMsg(ex.Message);
                }
            }
        }


        public static async Task<string> registrarAsync()
        {
            TokenManager manager = new TokenManager();
            Erro.erro = false;
            string route = "/account/signup";

            SignUpViewModel model = new SignUpViewModel();
            model.Email = User.Email;
            model.Password = User.Senha;
            model.Name = User.Nome;

            using (var client = new HttpClient())
            {
                var endPoint = new Uri(url + route);

                var jsonUser = JsonConvert.SerializeObject(model);
                var payload = new StringContent(jsonUser, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync(endPoint, payload);

                    if (response.IsSuccessStatusCode)
                    {
                        return "Conta criada com sucesso";
                    }
                    else
                    {
                        Erro.setMsg(response.ReasonPhrase);
                        return Erro.msg;
                    }
                }
                catch (Exception ex)
                {
                    Erro.setMsg("Erro ao se conectar com o servidor: " + ex.Message);
                    return Erro.msg;
                }
            }
        }

        public static async Task getUser()
        {
            TokenManager manager = new TokenManager();
            Erro.erro = false;
            string route = "/account/";

            string userId = manager.GetUserIdFromToken();
            if (string.IsNullOrEmpty(userId))
            {
                Erro.setMsg("Erro ao obter o ID do usuário a partir do token.");
                return;
            }

            using (var client = new HttpClient())
            {
                var endPoint = new Uri(url + route + userId);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", manager.GetToken());
                

                try
                {
                    var response = await client.GetAsync(endPoint);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        User user = JsonConvert.DeserializeObject<User>(content);

                        User.AtualizarPropriedadesEstaticas(user);
                    }
                    else
                    {
                        Erro.setMsg(response.ReasonPhrase);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    Erro.setMsg("Erro ao se conectar com o servidor: " + ex.Message);
                    return;
                }
            }
        }

        public static async Task<List<User>> getUsersAsync()
        {
            TokenManager manager = new TokenManager();
            List<User> users = new List<User>();
            Erro.erro = false;
            string route = "/account";

            using (var client = new HttpClient())
            {
                var endPoint = new Uri(url + route);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", manager.GetToken());

                try
                {
                    var response = await client.GetAsync(endPoint);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        users = JsonConvert.DeserializeObject<List<User>>(content);

                        return users;
                    }
                    else
                    {
                        Erro.setMsg(response.ReasonPhrase);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Erro.setMsg("Erro ao se conectar com o servidor: " + ex.Message);
                    return null;
                }
            }
        }

        public static async Task deleteUserAsync(int id)
        {
            TokenManager manager = new TokenManager();
            Erro.erro = false;
            string route = "/account/";

            using (var client = new HttpClient())
            {
                var endPoint = new Uri(url + route + id);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", manager.GetToken());

                try
                {
                    var response = await client.DeleteAsync(endPoint);

                    if (!response.IsSuccessStatusCode)
                    {
                        Erro.setMsg(response.ReasonPhrase);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    Erro.setMsg("Erro ao se conectar com o servidor: " + ex.Message);
                    return;
                }
            }
        }

        public static async Task<Image> getImageAsync(string path)
        {
            TokenManager manager = new TokenManager();
            Erro.erro = false;
            string route = "/account/images/";

            using (var client = new HttpClient())
            {
                var endPoint = new Uri(url + route + path);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", manager.GetToken());

                try
                {
                    var response = await client.GetAsync(endPoint);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsByteArrayAsync();
                        using (var memoryStream = new MemoryStream(content))
                        {
                            return Image.FromStream(memoryStream);
                        }
                    }
                    else
                    {
                        Erro.setMsg(response.ReasonPhrase);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Erro.setMsg("Erro ao se conectar com o servidor: " + ex.Message);
                    return null;
                }
            }
        }

        /*
            Area das habilidades 
        */

        public static async Task<Habilidade> getHabilidadeAsync(Habilidade habilidade)
        {
            TokenManager manager = new TokenManager();
            Erro.erro = false;
            string route = "/habilidade/";

            string id = "" + habilidade.Id;

            using (var client = new HttpClient())
            {
                var endPoint = new Uri(url + route + id);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", manager.GetToken());


                try
                {
                    var response = await client.GetAsync(endPoint);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        habilidade = JsonConvert.DeserializeObject<Habilidade>(content);

                        return habilidade;
                    }
                    else
                    {
                        Erro.setMsg(response.ReasonPhrase);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Erro.setMsg("Erro ao se conectar com o servidor: " + ex.Message);
                    return null;
                }
            }
        }

        public static async Task<Habilidade> getHabilidadeByNameAsync(Habilidade habilidade)
        {
            TokenManager manager = new TokenManager();
            Erro.erro = false;
            string route = "/habilidade/";

            string nome = habilidade.Nome;

            using (var client = new HttpClient())
            {
                var endPoint = new Uri(url + route + nome);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", manager.GetToken());


                try
                {
                    var response = await client.GetAsync(endPoint);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        habilidade = JsonConvert.DeserializeObject<Habilidade>(content);

                        return habilidade;
                    }
                    else
                    {
                        Erro.setMsg(response.ReasonPhrase);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Erro.setMsg("Erro ao se conectar com o servidor: " + ex.Message);
                    return null;
                }
            }
        }

        public static async Task<List<Habilidade>> getHabilidadesAsync()
        {
            TokenManager manager = new TokenManager();
            List<Habilidade> habilidades = new List<Habilidade>();
            Erro.erro = false;
            string route = "/habilidades";

            using (var client = new HttpClient())
            {
                var endPoint = new Uri(url + route);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", manager.GetToken());

                try
                {
                    var response = await client.GetAsync(endPoint);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        habilidades = JsonConvert.DeserializeObject<List<Habilidade>>(content);

                        return habilidades;
                    }
                    else
                    {
                        Erro.setMsg(response.ReasonPhrase);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Erro.setMsg("Erro ao se conectar com o servidor: " + ex.Message);
                    return null;
                }
            }
        }

        public static async Task deletaHabilidadeAsync(int id)
        {
            TokenManager manager = new TokenManager();
            Erro.erro = false;
            string route = "/habilidades/";

            using (var client = new HttpClient())
            {
                var endPoint = new Uri(url + route + id);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", manager.GetToken());

                try
                {
                    var response = await client.DeleteAsync(endPoint);

                    if (!response.IsSuccessStatusCode)
                    {
                        Erro.setMsg(response.ReasonPhrase);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    Erro.setMsg("Erro ao se conectar com o servidor: " + ex.Message);
                    return;
                }
            }
        }

        public static async Task<Habilidade> createHabilidadeAsync(HabilidadeViewModel.CreateHabilidade model)
        {
            TokenManager manager = new TokenManager();
            Erro.erro = false;
            string route = "/habilidades";
            Habilidade habilidade = new Habilidade();

            var habilidadeJson = JsonConvert.SerializeObject(model);
            var payload = new StringContent(habilidadeJson, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var endPoint = new Uri(url + route);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", manager.GetToken());

                try
                {
                    var response = await client.PostAsync(endPoint, payload);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        habilidade = JsonConvert.DeserializeObject<Habilidade>(content);

                        return habilidade;
                    }
                    else
                    {
                        Erro.setMsg(response.ReasonPhrase);
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Erro.setMsg("Erro ao se conectar com o servidor: " + ex.Message);
                    return null;
                }
            }
        }

        public async static Task updateHabilidadeAsync(HabilidadeViewModel.CreateHabilidade model)
        {
            TokenManager manager = new TokenManager();
            Erro.erro = false;
            string route = "/habilidades/";

            Habilidade habilidade = new Habilidade { Nome = model.Nome };
            habilidade = await getHabilidadeByNameAsync(habilidade);

            if (habilidade == null || habilidade.Id == 0)
            {
                Erro.setMsg("Habilidade não encontrada com o nome especificado.");
                return;
            }

            var habilidadeJson = JsonConvert.SerializeObject(model);
            var payload = new StringContent(habilidadeJson, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var endPoint = new Uri(url + route + habilidade.Id);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", manager.GetToken());

                try
                {
                    var response = await client.PutAsync(endPoint, payload);

                    if (response.IsSuccessStatusCode)
                    {
                        return;
                    }
                    else
                    {
                        Erro.setMsg(response.ReasonPhrase);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    Erro.setMsg("Erro ao se conectar com o servidor: " + ex.Message);
                    return;
                }
            }
        }
    }
}
