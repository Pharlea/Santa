using RPG_UI.BLLs;
using RPG_UI.Models;
using System.Windows.Forms;

namespace RPG_UI.Forms
{
    public partial class FormViewUser : Form
    {
        private User user;
        public FormViewUser(User _user)
        {
            InitializeComponent();

            user = _user;
        }

        private async void FormViewUser_Load(object sender, System.EventArgs e)
        {
            tb_id.Text = user.id.ToString();
            tb_nome.Text = user.nome;
            tb_email.Text = user.email;
            tb_role.Text = user.role;
            pb_fotoPerfil.Image = await UserBLL.GetImageAsync(user.fotoPerfil);
        }

        private async void bt_deletar_Click(object sender, System.EventArgs e)
        {
            DialogResult response = new DialogResult();

            response = MessageBox.Show($"Você têm certeza que deseja deletar a conta {user.id} (de {user.nome})?", "Aviso" ,MessageBoxButtons.YesNo);

            if (response == DialogResult.No)
                return;

            if (user.role == "Admin")
            {
                response = MessageBox.Show($"Você têm certeza? O usuário {user.nome} é um admin", "Aviso", MessageBoxButtons.YesNo);

                if (response == DialogResult.No)
                    return;
            }

            await UserBLL.deleteUserAsync(user.id);

            if (Erro.erro)
                MessageBox.Show(Erro.msg);
            else
                MessageBox.Show($"Conta {user.id} de {user.nome} foi apagada com sucesso.");
        }
    }
}
