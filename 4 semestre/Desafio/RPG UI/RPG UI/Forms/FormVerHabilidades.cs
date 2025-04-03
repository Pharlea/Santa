using RPG_UI.BLLs;
using RPG_UI.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RPG_UI
{
    public partial class FormVerHabilidades : Form
    {
        public FormVerHabilidades()
        {
            InitializeComponent();
        }

        private async void bt_buscar_Click(object sender, EventArgs e)
        {
            Habilidade habilidade = new Habilidade();

            try
            {
                habilidade.Id = int.Parse(tb_barraDePesquisa.Text);
            }
            catch
            {
                habilidade.Nome = tb_barraDePesquisa.Text;
            }

            if (habilidade.Nome == "")
                habilidade = await HabilidadeBLL.GetHabilidadeAsync(habilidade);
            else
                habilidade = await HabilidadeBLL.GetHabilidadeByNameAsync(habilidade);

            if (Erro.erro)
                MessageBox.Show(Erro.msg);
            else
            {
                pn_main.Controls.Clear();
                loadForm(habilidade);
            }
        }

        private async void bt_buscarTodas_Click(object sender, EventArgs e)
        {
            List<Habilidade> habilidades = new List<Habilidade>();

            habilidades = await HabilidadeBLL.GetHabilidadesAsync();

            if (Erro.erro)
            {
                MessageBox.Show(Erro.msg);
                return;
            }

            pn_main.Controls.Clear();
            foreach (Habilidade habilidade in habilidades)
            {
                loadForm(habilidade);
                loadVoid();
            }
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Tag = 1;
        }

        private void loadForm(Habilidade habilidade)
        {
            FormViewHabilidade formViewHabilidade = new FormViewHabilidade(habilidade);

            formViewHabilidade.TopLevel = false;
            formViewHabilidade.Dock = DockStyle.Top;
            this.pn_main.Controls.Add(formViewHabilidade);

            formViewHabilidade.BringToFront();
            formViewHabilidade.Show();
        }

        private void loadVoid()
        {
            FormVoid temp = new FormVoid();

            temp.TopLevel = false;
            temp.Dock = DockStyle.Top;
            this.pn_main.Controls.Add(temp);

            temp.BringToFront();
            temp.Show();
        }

        /*
            Mudar cor dos botões 
        */

        private void bt_deletar_MouseEnter(object sender, EventArgs e)
        {
            bt_deletar.BackColor = Color.Red;
        }

        private void bt_deletar_MouseLeave(object sender, EventArgs e)
        {
            bt_deletar.BackColor = Color.Black;
        }

        private void bt_criar_editar_MouseEnter(object sender, EventArgs e)
        {
            bt_criar_editar.BackColor = Color.YellowGreen;
        }

        private void bt_criar_editar_MouseLeave(object sender, EventArgs e)
        {
            bt_criar_editar.BackColor = Color.Black;
        }

        private void bt_deletar_Click(object sender, EventArgs e)
        {
            if (User.Role != "Admin")
            {
                MessageBox.Show("Você não tem permissão para acessar esta página");
                return;
            }

            this.Tag = 4;
        }

        private void bt_criar_editar_Click(object sender, EventArgs e)
        {
            if (User.Role != "Admin")
            {
                MessageBox.Show("Você não tem permissão para acessar esta página");
                return;
            }

            this.Tag = 5;
        }
    }
}
