using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPG_UI.BLLs;
using RPG_UI.DAL;
using RPG_UI.Models;
using System.Threading;

namespace RPG_UI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private async void bt_enviar_Click(object sender, EventArgs e)
        {
            TokenManager manager = new TokenManager();

            User.Email = tb_email.Text;
            User.Senha = tb_senha.Text;
            lb_incorreto.Text = "";

            UserBLL.verificaLogin();

            if (Erro.erro)
            {
                tb_senha.BorderColor = Color.Red;
                lb_incorreto.Text = $"({Erro.msg})";
                return;
            }
            tb_senha.BorderColor = Color.White;

            await UserBLL.getLoginAsync();
            if (Erro.erro)
            {
                lb_incorreto.Text = Erro.msg;
                return;
            }

            await UserBLL.getUser();

            if (Erro.erro)
                lb_incorreto.Text = Erro.msg;
            else
            {
                if (User.Nome != "")
                    lb_titulo.Text = User.Nome;
                else
                    lb_titulo.Text = "Vazio";
                Thread.Sleep(10000);
                this.Tag = 1;
            }
        }

        private void llb_registrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Tag = 3;
        }
    }
}
