using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversãoDistancia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Valor;
            Conversor conversor = new Conversor();
            Valor = textBox1.Text;

            conversor.valor = Valor;

            textBox1.Text = "";
            conversorBLL.ValidaDados(conversor);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                if (KmOuMilha.SelectedIndex == 1)
                {                    
                    ValorConvertido.Text = "valor convertido:                 " + conversor.ConverterParaMilhas(Valor); 
                }
                else
                {                    
                    ValorConvertido.Text = "valor convertido:                 " + conversor.ConverterParaKm(Valor); ;
                }
            }
        }

        private void bt_calc_Click(object sender, EventArgs e)
        {
            string Valor;
            Conversor conversor = new Conversor();
            Valor = textBox2.Text;

            conversor.valor = Valor;

            conversorBLL.ValidaDados(conversor);
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMens());
            }
            else
            {
                if (radioButton1.Checked)
                {
                    textBox2.Text = "";
                    lb_valor_convertido_radio.Text = "valor convertido:                 " + conversor.ConverterParaMilhas(Valor);
                }
                else
                {
                    if(radioButton2.Checked)
                    {
                        textBox2.Text = "";
                        lb_valor_convertido_radio.Text = "valor convertido:                 " + conversor.ConverterParaKm(Valor); ;
                    }
                }                
            }
        }
    }
}
