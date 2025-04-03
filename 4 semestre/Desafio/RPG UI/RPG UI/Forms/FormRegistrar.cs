using RPG_UI.BLLs;
using RPG_UI.Models;
using RPG_UI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RPG_UI.ViewModels.UserViewModel;

namespace RPG_UI
{
    public partial class FormRegistrar : Form
    {
        public FormRegistrar()
        {
            InitializeComponent();
        }

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Tag = 0;
        }

        private async void bt_registrar_Click(object sender, EventArgs e)
        {
            SignUpViewModel model = new SignUpViewModel();
            lb_resultado.ForeColor = Color.Gray;

            User.Nome = tb_nomeDeUsuario.Text;
            User.Email = tb_email.Text;
            User.Senha = tb_senha.Text;

            UserBLL.verificaSignUp();

            if (Erro.erro)
            {
                lb_resultado.Text = Erro.msg;
                if (Erro.msg[0] == 'O')
                    tb_nomeDeUsuario.BorderColor = Color.Red;
                else
                    tb_senha.BorderColor = Color.Red;
            }

            string resultado = await UserBLL.registrarAsync();

            if (!Erro.erro)
            {
                lb_resultado.ForeColor = Color.Lime;
                lb_resultado.Text = resultado;
            }
            else
            {
                lb_resultado.Text = Erro.msg;
            }
        }
    }
}
