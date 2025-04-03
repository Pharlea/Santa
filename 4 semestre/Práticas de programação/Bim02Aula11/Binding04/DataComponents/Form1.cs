using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataComponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDVendasDataSet2.Meses' table. You can move, or remove it, as needed.
            this.mesesTableAdapter.Fill(this.bDVendasDataSet2.Meses);
            // TODO: This line of code loads data into the 'bDVendasDataSet1.TabTotalVendas' table. You can move, or remove it, as needed.
            this.tabTotalVendasTableAdapter.Fill(this.bDVendasDataSet1.TabTotalVendas);
            // TODO: This line of code loads data into the 'bDVendasDataSet.TabVendedor' table. You can move, or remove it, as needed.
            this.tabVendedorTableAdapter.Fill(this.bDVendasDataSet.TabVendedor); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            
            bindingSource2.Filter = "CodigoVendedor = '" + bindingSource1.Find("Nome", comboBox1.Text) + "'";
            chart1.DataBindTable(bindingSource2, "Mes");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            bindingSource2.Filter = "Mes = '" + comboBox2.Text + "'";
            chart1.DataBindTable(bindingSource2, "Mes");
        }
    }
}
