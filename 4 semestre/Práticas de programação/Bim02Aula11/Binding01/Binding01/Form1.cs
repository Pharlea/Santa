using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binding01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDLivrosDataSet1.TabPessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.tabPessoaTableAdapter.Fill(this.bDLivrosDataSet1.TabPessoa);
            // TODO: esta linha de código carrega dados na tabela 'bDLivrosDataSet.TabLivro'. Você pode movê-la ou removê-la conforme necessário.
            this.tabLivroTableAdapter.Fill(this.bDLivrosDataSet.TabLivro);

        }
    }
}
