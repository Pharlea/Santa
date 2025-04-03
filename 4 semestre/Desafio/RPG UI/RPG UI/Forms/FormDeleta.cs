using RPG_UI.BLLs;
using RPG_UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_UI
{
    public partial class FormDeleta : Form
    {
        public FormDeleta()
        {
            InitializeComponent();
        }

        private async void bt_deletar_Click(object sender, EventArgs e)
        {
            Habilidade habilidade = new Habilidade();
            habilidade.Id = int.Parse(tb_id.Text);

            habilidade = await HabilidadeBLL.GetHabilidadeAsync(habilidade);

            if (Erro.erro)
            {
                MessageBox.Show(Erro.msg);
                return;
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja apagar a habilidade '" + habilidade.Nome + "'?", "Aviso", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.No)
                    return;

                await HabilidadeBLL.deletaHabilidadeAsync(habilidade.Id);

                if (Erro.erro)
                    MessageBox.Show(Erro.msg);
                else
                    MessageBox.Show("A habilidade " + habilidade.Nome + " foi deletada com sucesso.");
            }
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Tag = 2;
        }

        private void bt_deletar_MouseEnter(object sender, EventArgs e)
        {
            bt_deletar.BackColor = Color.Red;
        }

        private void bt_deletar_MouseLeave(object sender, EventArgs e)
        {
            bt_deletar.BackColor = Color.Black;
        }

        private void bt_voltar_MouseEnter(object sender, EventArgs e)
        {
            bt_voltar.BackColor = Color.DimGray;
        }

        private void bt_voltar_MouseLeave(object sender, EventArgs e)
        {
            bt_voltar.BackColor = Color.Black;
        }
    }
}
