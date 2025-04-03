using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binding02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDLivrosDataSet.TabPessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.tabLivroTableAdapter.Fill(this.bDLivrosDataSet.TabLivro);
            // TODO: esta linha de código carrega dados na tabela 'bDLivrosDataSet.TabLivro'. Você pode movê-la ou removê-la conforme necessário.
            this.tabPessoaTableAdapter.Fill(this.bDLivrosDataSet.TabPessoa);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                bindingSource1.DataMember = "TabLivro";
                dataGridView1.DataSource = bindingSource1;
            }
            else
            {
                bindingSource1.DataMember = "TabPessoa";
                dataGridView1.DataSource = bindingSource1;
            }
        }
    }
}
