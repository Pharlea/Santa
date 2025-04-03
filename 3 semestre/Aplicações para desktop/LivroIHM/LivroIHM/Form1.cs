using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivroIHM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();

            livro.setTitulo = textBox1.Text;
            livro.setAutor = textBox2.Text;
            livro.setEditora = textBox3.Text;
            livro.setAnoedicao = textBox4.Text;
            livro.setLocal = textBox5.Text;

            LivroBLL livroBLL = new LivroBLL();
            livroBLL.validaDados(livro);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
        }
    }
}
