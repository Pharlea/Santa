using RPG_UI.BLLs;
using RPG_UI.Forms;
using RPG_UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace RPG_UI
{
    public partial class FormHome : Form
    {
        public Point mouseLocal;
        public static Form currentForm = new Form();
        private Thread formManagerThread, buttonManagerThread;
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;
        private Stack<int> lastForm = new Stack<int>();

        public FormHome()
        {
            InitializeComponent();
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;
            formManagerThread = new Thread(() => formManager(cancellationToken));
            buttonManagerThread = new Thread(() => buttonManager(cancellationToken));

            User.StaticPropertyChanged += User_StaticPropertyChanged;
        }

        public async void FormHome_Load(object sender, EventArgs e)
        {
            loadForm(new FormPlaceholder());
            await UserBLL.getUser();

            if (Erro.erro)
                currentForm.Tag = 0;
            else
            {
                lb_userName.Text = User.Nome;
                currentForm.Tag = 1;
            }

            formManagerThread.Start();
            buttonManagerThread.Start();
        }

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
            buttonManagerThread.Abort();
            formManagerThread.Join();
            User.StaticPropertyChanged -= User_StaticPropertyChanged;
        }

        /*
            Config Form 
        */

        private void FormHome_TextChanged(object sender, EventArgs e)
        {
            lb_titulo.Text = this.Text;
        }

        private void pn_controlBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocal = new Point(-e.X, -e.Y);
        }

        private void pn_controlBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocal.X, mouseLocal.Y);
                Location = mousePose;
            }
        }

        /*
            Manipular Forms 
        */

        private void loadForm(Form form)
        {
            if (this.pn_Main.Controls.Count > 0)
                this.pn_Main.Controls.RemoveAt(0);

            currentForm = form;
            currentForm.TopLevel = false;
            currentForm.Dock = DockStyle.Fill;
            this.pn_Main.Controls.Add(currentForm);
            this.pn_Main.Tag = currentForm;
            currentForm.Show();
        }

        private void formManager(CancellationToken cancellationToken)
        {
            int lastTagValue = -1;
            lastForm.Push(lastTagValue);

            while (!cancellationToken.IsCancellationRequested)
            {
                if (currentForm.Tag is int tag && tag != lastForm.Peek())
                    lastForm.Push(tag);

                if (currentForm.Tag is int tagValue && tagValue != lastTagValue)
                {
                    lastTagValue = tagValue;

                    this.Invoke(new Action(() =>
                    {
                        switch (tagValue)
                        {
                            case -2:
                                lastForm.Pop();
                                lastForm.Pop();
                                currentForm.Tag = lastForm.Pop();
                                break;
                            case -1:
                                loadForm(new FormPlaceholder());
                                this.Text = "Carregando...";
                                break;
                            case 0:
                                loadForm(new FormLogin());
                                this.Text = "Login";
                                break;
                            case 1:
                                loadForm(new FormMenu());
                                this.Text = "Menu";
                                break;
                            case 2:
                                loadForm(new FormVerHabilidades());
                                this.Text = "Habilidades";
                                break;
                            case 3:
                                loadForm(new FormRegistrar());
                                this.Text = "Registrar";
                                break;
                            case 4:
                                loadForm(new FormDeleta());
                                this.Text = "Deletar";
                                break;
                            case 5:
                                loadForm(new FormCriarEditar());
                                this.Text = "Criar/Editar";
                                break;
                            case 6:
                                loadForm(new FormAdminWindow());
                                this.Text = "Admin Window";
                                break;
                        }
                    }));
                }
                Thread.Sleep(100);
            }
        }

        private void User_StaticPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            FormRegistrar form = new FormRegistrar();
            if (currentForm.GetType() != form.GetType())
                lb_userName.Text = User.Nome;
            form.Close();
        }

        private void buttonManager(CancellationToken cancellationToken)
        {            
            while (!cancellationToken.IsCancellationRequested)
            {
                if (lb_userName.Text != "")
                {
                    this.Invoke(new Action(() =>
                    {
                        bt_sairConta.Visible = true;

                        if (User.Role != "Admin")
                            bt_verUsuarios.Visible = false;
                        else
                            bt_verUsuarios.Visible = true;
                    }));
                }
                else
                {
                    this.Invoke(new Action(() =>
                    {
                        bt_sairConta.Visible = false;
                        bt_verUsuarios.Visible = false;
                    }));
                }
            }
        }

        /*
            Botões da barra de controle 
        */

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_windowState_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
        }

        private void bt_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bt_verUsuarios_Click(object sender, EventArgs e)
        {
            currentForm.Tag = 6;
        }

        private void bt_sairConta_Click(object sender, EventArgs e)
        {
            User.Nome = null;
            User.Senha = null;
            User.Email = null;
            User.FotoPerfil = null;
            User.Id = 0;
            User.Role = null;

            TokenManager manager = new TokenManager();
            Token token = new Token();
            token.token = "";
            manager.SaveToken(token);
            currentForm.Tag = 0;
        }
    }
}
