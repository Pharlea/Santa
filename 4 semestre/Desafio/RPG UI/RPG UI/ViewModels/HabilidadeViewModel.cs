using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_UI.ViewModels
{
    public static class HabilidadeViewModel
    {
        public class CreateHabilidade
        {
            public string Nome { get; set; }
            public string Categoria { get; set; }
            public char Rank { get; set; }
            public string TipoDeAcao { get; set; }
            public string Cooldown { get; set; }
            public string Conjuracao { get; set; }
            public int DT { get; set; }
            public string Efeito { get; set; }
        }
    }
}
