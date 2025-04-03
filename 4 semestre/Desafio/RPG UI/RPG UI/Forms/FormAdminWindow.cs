using RPG_UI.BLLs;
using RPG_UI.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RPG_UI.Forms
{
    public partial class FormAdminWindow : Form
    {
        public FormAdminWindow()
        {
            InitializeComponent();
        }

        private async void bt_buscar_Click(object sender, EventArgs e)
        {
            List<User> users = new List<User>();

            users = await UserBLL.GetUsersAsync();

            if (Erro.erro)
            {
                MessageBox.Show(Erro.msg);
                return;
            }

            foreach (User user in users)
            {
                loadForm(user);
                loadVoid();
            }
        }

        private void loadForm(User user)
        {
            FormViewUser formViewuser = new FormViewUser(user);

            formViewuser.TopLevel = false;
            formViewuser.Dock = DockStyle.Top;
            this.pn_main.Controls.Add(formViewuser);

            formViewuser.BringToFront();
            formViewuser.Show();
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

        private void bt_voltar_Click(object sender, EventArgs e)
        {
            this.Tag = -2;
        }
    }
}
