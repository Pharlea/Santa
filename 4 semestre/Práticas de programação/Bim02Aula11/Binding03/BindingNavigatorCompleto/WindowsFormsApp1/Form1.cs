using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabLivroBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabLivroBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdLivrosDataSet1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdLivrosDataSet1.TabLivro'. Você pode movê-la ou removê-la conforme necessário.
            this.tabLivroTableAdapter.Fill(this.bdLivrosDataSet1.TabLivro);

        }
    }
}
