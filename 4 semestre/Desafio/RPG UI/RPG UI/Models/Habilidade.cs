using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_UI.Models
{
    public class Habilidade
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public char Rank { get; set; }
        public int CustoDeMana { get; set; }
        public string TipoDeAcao { get; set; } = string.Empty;
        public string Cooldown { get; set; } = string.Empty;
        public string Conjuracao { get; set; } = string.Empty;
        public int DT { get; set; }
        public string Efeito { get; set; } = string.Empty;
    }
}
