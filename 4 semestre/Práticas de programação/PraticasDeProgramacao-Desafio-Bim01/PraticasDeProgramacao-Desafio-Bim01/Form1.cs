using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PraticasDeProgramacao_Desafio_Bim01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_criar_Click(object sender, EventArgs e)
        {
            FormCriar formCriar = new FormCriar();
            formCriar.Show();
            this.Hide();
        }

        private void bt_ler_Click(object sender, EventArgs e)
        {
            FormLer formLer = new FormLer();
            formLer.Show();
            this.Hide();
        }

        private void bt_deletar_Click(object sender, EventArgs e)
        {
            FormDeletar formDeletar = new FormDeletar();
            formDeletar.Show();
            this.Hide();
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            FormEditar formEditar = new FormEditar();
            formEditar.Show();
            this.Hide();
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
