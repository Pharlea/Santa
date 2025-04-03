using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();

            aluno.P1 = notaP1.Text;
            aluno.P2 = notaP2.Text;
            aluno.P3 = notaP3.Text;
            aluno.P4 = notaP4.Text;

            MediaBLL.ValidaDados(aluno);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                notaP1.Enabled = false;
                notaP2.Enabled = false;
                notaP3.Enabled = false;
                notaP4.Enabled = false;
                label5.Text = "Média:     " + aluno.GetMedia(aluno.P1, aluno.P2, aluno.P3, aluno.P4);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notaP1.Clear();
            notaP2.Clear();
            notaP3.Clear();
            notaP4.Clear();
            notaP1.Enabled = true;
            notaP2.Enabled = true;
            notaP3.Enabled = true;
            notaP4.Enabled = true;
            label5.Text = "Média:     ";
            notaP1.Focus();
        }
    }
}
