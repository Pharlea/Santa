using RPG_UI.BLLs;
using RPG_UI.Models;
using RPG_UI.ViewModels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RPG_UI
{
    public partial class FormCriarEditar : Form
    {
        public FormCriarEditar()
        {
            InitializeComponent();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Tag = 2;
        }

        private async void bt_buscar_Click(object sender, EventArgs e)
        {
            Habilidade habilidade = new Habilidade();

            habilidade.Id = int.Parse(tb_buscar.Text);

            habilidade = await HabilidadeBLL.GetHabilidadeAsync(habilidade);

            if (Erro.erro)
            {
                MessageBox.Show(Erro.msg);
                return;
            }

            tb_nome.Text = habilidade.Nome;
            tb_rank.Text = "" + habilidade.Rank;
            tb_categoria.Text = habilidade.Categoria;
            tb_cooldown.Text = habilidade.Cooldown;
            tb_conjuracao.Text = habilidade.Conjuracao;
            tb_tipoDeAcao.Text = habilidade.TipoDeAcao;
            tb_dt.Text = habilidade.DT.ToString();
            tb_efeito.Text = habilidade.Efeito;
        }

        private async void bt_criar_Click(object sender, EventArgs e)
        {
            HabilidadeViewModel.CreateHabilidade createHabilidade = new HabilidadeViewModel.CreateHabilidade();
            int aux;

            createHabilidade.Nome = tb_nome.Text;
            createHabilidade.Rank = tb_rank.Text[0];
            createHabilidade.Categoria = tb_categoria.Text;
            createHabilidade.Cooldown = tb_cooldown.Text;
            createHabilidade.Conjuracao = tb_conjuracao.Text;
            createHabilidade.Efeito = tb_efeito.Text;
            createHabilidade.TipoDeAcao = tb_tipoDeAcao.Text;

            if (int.TryParse(tb_dt.Text, out aux))
                createHabilidade.DT = aux;


            Habilidade habilidade = new Habilidade();
            habilidade = await HabilidadeBLL.createHabilidadeAsync(createHabilidade);

            if (Erro.erro) { MessageBox.Show(Erro.msg); return; }
            else { MessageBox.Show("Habilidade '" + habilidade.Nome + "' criada com sucesso."); }
        }

        private async void bt_editar_Click(object sender, EventArgs e)
        {
            HabilidadeViewModel.CreateHabilidade createHabilidade = new HabilidadeViewModel.CreateHabilidade();
            int aux;

            try
            {
                createHabilidade.Nome = tb_nome.Text;
                createHabilidade.Rank = tb_rank.Text[0];
                createHabilidade.Categoria = tb_categoria.Text;
                createHabilidade.Cooldown = tb_cooldown.Text;
                createHabilidade.Conjuracao = tb_conjuracao.Text;
                createHabilidade.Efeito = tb_efeito.Text;
                createHabilidade.TipoDeAcao = tb_tipoDeAcao.Text;
            }
            catch
            { return; }

            if (int.TryParse(tb_dt.Text, out aux))
                createHabilidade.DT = aux;

            await HabilidadeBLL.updateHabilidadeAsync(createHabilidade);

            if (Erro.erro) { MessageBox.Show(Erro.msg); return; }
            else { MessageBox.Show("Habilidade '" + createHabilidade.Nome + "' atualizada com sucesso."); }
        }

        /*
            Manejar cores dos botões 
        */

        private void bt_criar_MouseEnter(object sender, EventArgs e)
        {
            bt_criar.BackColor = Color.DimGray;
        }

        private void bt_criar_MouseLeave(object sender, EventArgs e)
        {
            bt_criar.BackColor = Color.Black;
        }

        private void bt_editar_MouseEnter(object sender, EventArgs e)
        {
            bt_editar.BackColor = Color.DimGray;
        }

        private void bt_editar_MouseLeave(object sender, EventArgs e)
        {
            bt_editar.BackColor = Color.Black;
        }
    }
}
