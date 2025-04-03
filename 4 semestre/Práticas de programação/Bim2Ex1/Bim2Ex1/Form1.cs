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
            float somVal = 0, somTon = 0;

            tb_nome.Clear();
            tb_somaTon.Clear();
            tb_somaVal.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();



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
                while (!Erro.getErro())
                {
                    listBox1.Items.Add (VendasCliente.getData());

                    listBox2.Items.Add(VendasCliente.getToneladas());
                    somTon += float.Parse (VendasCliente.getToneladas());

                    listBox3.Items.Add(VendasCliente.getValor());
                    somVal += float.Parse(VendasCliente.getValor());

                    Sem2Ex1BLL.consultaVendaCliente();
                }
                    tb_somaTon.Text = "" + somTon;
                    tb_somaVal.Text = "" + somVal;

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
