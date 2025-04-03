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

namespace SerialEnvia
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.Text == "Iniciar")
            {
                try
                {
                    serialPort1.Open();
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add("Erro ao se conectar a porta COM5 (" + ex + ")");
                    return;
                }

                button1.Text = "Finalizar";
                timer1.Enabled = true;
            }
            else
            {
                button1.Text = "Iniciar";
                timer1.Enabled = false;

                serialPort1.WriteLine("400");
                serialPort1.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random gerador = new Random();
            int amostra = gerador.Next(100);            

            try
            {
                listBox1.Items.Add(amostra);
                serialPort1.WriteLine(amostra.ToString());
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("Erro ao se conectar a porta COM5 (" + ex + ")");
            }
        }
    }
}
