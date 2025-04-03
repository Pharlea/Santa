using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_registrar_pessoas_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadPessoa_load(object sender, EventArgs e)
        {
            PessoaBLL.conecta();
            if (Erro.getErro()) { MessageBox.Show(Erro.getMsg()); }
        }

        private void salvar_bt_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.codigo = código_tb.Text;
            pessoa.idade = "" + idade_nud1.Value;
            pessoa.nome = nome_tb.Text;
            if (sexo_cb.Text == "Masc")
                pessoa.sexo = "M";
            else
                pessoa.sexo = "F";

            PessoaBLL.verificaDados(pessoa);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
            }
            else
            {
                MessageBox.Show("Dados salvos!");
            }
        }

        private void limpar_bt_Click(object sender, EventArgs e)
        {
            nome_tb.Clear();
            código_tb.Clear();
            idade_nud1.Value = 0;
        }

        private void ler_bt_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.codigo = código_tb.Text;
            
            PessoaBLL.verificaCodigo(pessoa);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
            }
            else
            {
                nome_tb.Text = pessoa.nome;
                idade_nud1.Value = int.Parse(pessoa.idade);
                sexo_cb.Text = pessoa.sexo;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PessoaBLL.conecta();
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                Application.Exit(); 
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            PessoaBLL.desconecta();
        }
    }
}
