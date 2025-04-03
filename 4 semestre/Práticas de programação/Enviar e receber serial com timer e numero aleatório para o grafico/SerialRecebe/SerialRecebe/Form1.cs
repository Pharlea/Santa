using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialRecebe
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool fim = true;
            int n;

            try
            {
                serialPort1.Open();                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            while(fim)
            {
                n = int.Parse(serialPort1.ReadLine());

                if (n > 100)
                {
                    fim = false;
                }

                Amostras.amostra = n.ToString();
                Amostras.data = DateTime.Now.Date.ToString();
                Amostras.hora = DateTime.Now.TimeOfDay.ToString();
                RecebeDAL.insereAmostra();

                chart1.Series[0].Points.AddXY(0, n);
                Refresh();
            }
            serialPort1.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            RecebeDAL.conecta();
            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMsg());
                Application.Exit();
            }
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            RecebeDAL.desconecta();
        }
    }
}
