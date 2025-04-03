using RPG_UI.Models;
using System.Windows.Forms;

namespace RPG_UI
{
    public partial class FormViewHabilidade : Form
    {
        public FormViewHabilidade(Habilidade habilidade)
        {
            InitializeComponent();

            tb_nome.Text = habilidade.Nome;
            tb_id.Text = habilidade.Id.ToString();
            tb_rank.Text = habilidade.Rank.ToString();
            tb_categoria.Text = habilidade.Categoria;
            tb_conjuracao.Text = habilidade.Conjuracao;
            tb_cooldown.Text = habilidade.Cooldown;
            tb_tipoDeAcao.Text = habilidade.TipoDeAcao;
            tb_dt.Text = habilidade.DT.ToString();
            tb_efeito.Text = habilidade.Efeito;
        }
    }
}
