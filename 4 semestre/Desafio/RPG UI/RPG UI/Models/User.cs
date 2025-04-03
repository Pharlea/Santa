using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_UI.Models
{
    public class User
    {
        public static event PropertyChangedEventHandler StaticPropertyChanged;

        public static int Id { get; set; }
        public static string Nome
        {
            get => nomeAux;
            set
            {
                if (nomeAux != value)
                {
                    nomeAux = value;
                    OnStaticPropertyChanged(nameof(Nome)); 
                }
            }
        }
        private static string nomeAux = string.Empty;
        public static string Email { get; set; } = string.Empty;
        public static string Senha { get; set; } = string.Empty;
        public static string Role { get; set; } = string.Empty;
        public static string FotoPerfil { get; set; } = string.Empty;

        // Propriedades de instância
        public int id { get; set; }
        public string nome { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string senha { get; set; } = string.Empty;
        public string role { get; set; } = string.Empty;
        public string fotoPerfil { get; set; } = string.Empty;

        // Método para atualizar as propriedades estáticas
        public static void AtualizarPropriedadesEstaticas(User user)
        {
            Id = user.id;
            Nome = user.nome;
            Email = user.email;
            Senha = user.senha;
            Role = user.role;
            FotoPerfil = user.fotoPerfil;

            Console.WriteLine($"Nome atualizado para: {Nome}");
        }

        // Método para invocar o evento de notificação para propriedades estáticas
        private static void OnStaticPropertyChanged(string propertyName)
        {
            StaticPropertyChanged?.Invoke(typeof(User), new PropertyChangedEventArgs(propertyName));
        }
    }
}
