using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinemark
{
    public partial class Cinemark : Form
    {
        CalculaFaturamento calculaFaturamento = new CalculaFaturamento();
        public Cinemark()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[] bt = new Button[200];
            char lt = 'A';
            int col = 130, colNm = 1, nss = 19, lin = 1;
            
            for (int i = 0; i < 200; i++)
            {
                bt[i] = new Button();
                bt[i].Text = "" + lt + colNm;
                bt[i].Name = "bt" + lt + colNm;
                bt[i].BackColor = Color.LightGreen;
                bt[i].Location = new Point(col, 30 * (lin));

                lin++;
                lt++;

                if (i == nss) { col += 90; nss += 20; lin = 1; lt = 'A'; colNm++; }
                Controls.Add(bt[i]);
                bt[i].Click += new System.EventHandler(btGenerico);
            }
        }
        private void btGenerico(object sender, EventArgs e)
        {
            Button btAtual = (Button)sender;
            string mensagem = "Você está certo disso?";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo; DialogResult result ; result = MessageBox.Show(mensagem, mensagem, buttons);

            if (result == DialogResult.Yes)
            {
                if (btAtual.BackColor == Color.LightGreen)
                {
                    btAtual.BackColor = Color.IndianRed;
                    calculaFaturamento.numLugares++;
                }
                else
                {
                    btAtual.BackColor = Color.LightGreen;
                    calculaFaturamento.numLugares--;
                }
                this.calculaFaturamento.calculo();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("R$" + this.calculaFaturamento.Faturamento);
        }
    }
}
