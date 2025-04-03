using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bim2Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sem2Ex1BLL.desconecta();
        }

        private void bt_consultar_Click(object sender, EventArgs e)
        {
            float som = 0; int i=0;

            tb_nome.Clear();
            chart1.Series[0].Points.Clear();    
            Cliente.setCNPJ(tb_CNPJ.Text);
            Sem2Ex1BLL.validaCNPJ();

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
            }
            else
            {
                Sem2Ex1BLL.popularCliente();

                    Sem2Ex1BLL.consultaClientes();
                    tb_nome.Text = Cliente.getNome();
                    if (Erro.getErro())
                    {
                        MessageBox.Show(Erro.getMsg());
                    }


                Sem2Ex1BLL.popularVenda();
                Sem2Ex1BLL.consultaVendaCliente();

                if (rb_toneladas.Checked)
                {
                    while (!Erro.getErro())
                    {
                        chart1.Series[0].Points.AddXY(i, VendasCliente.getToneladas());
                        som += float.Parse(VendasCliente.getToneladas());

                        Sem2Ex1BLL.consultaVendaCliente();
                        i++;
                    }
                }
                else if (rb_valor.Checked)
                {
                    while (!Erro.getErro())
                    {
                        chart1.Series[0].Points.AddXY(i, VendasCliente.getValor());
                        som += float.Parse(VendasCliente.getValor());

                        Sem2Ex1BLL.consultaVendaCliente();
                        i++;
                    }
                }
                else
                {
                    MessageBox.Show("Escolha uma opção de visualização");
                }
                tb_soma.Text = "" + som;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Sem2Ex1BLL.conecta();
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
        }
    }
}
