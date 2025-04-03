using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino
{
    public partial class ArduinoIHM : Form
    {
        public ArduinoIHM()
        {
            InitializeComponent();
            textBox1.Text = ArduinoBLL.mostraBits(ArduinoBLL.getDisplay());
        }

        private void tratarBotoes(object sender, EventArgs e)
        {
            Button generico = (Button)sender;

            if (generico.Text == "Ligar")
            {
                generico.Text= "Desligar";
                ArduinoBLL.ligaDispositivo(generico.Tag.ToString());
                textBox1.Text = ArduinoBLL.mostraBits(ArduinoBLL.getDisplay());
            }
            else
            {
                generico.Text = "Ligar";
                ArduinoBLL.desligaDispositivo(generico.Tag.ToString());
                textBox1.Text = ArduinoBLL.mostraBits(ArduinoBLL.getDisplay());
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            desligaTudo();
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                ligaTudo();
                await Task.Delay(2000);

                desligaTudo();
                await Task.Delay(2000);
            }
        }

        private void desligaTudo()
        {
            ArduinoBLL.setDisplay(0);
            textBox1.Text = ArduinoBLL.mostraBits(ArduinoBLL.getDisplay());
            button1.Text = "Ligar";
            button2.Text = "Ligar";
            button3.Text = "Ligar";
            button4.Text = "Ligar";
            button5.Text = "Ligar";
            button6.Text = "Ligar";
            button7.Text = "Ligar";
            button8.Text = "Ligar";
        }

        private void ligaTudo()
        {
            ArduinoBLL.setDisplay(~0);
            textBox1.Text = ArduinoBLL.mostraBits(ArduinoBLL.getDisplay());
            button1.Text = "Desligar";
            button2.Text = "Desligar";
            button3.Text = "Desligar";
            button4.Text = "Desligar";
            button5.Text = "Desligar";
            button6.Text = "Desligar";
            button7.Text = "Desligar";
            button8.Text = "Desligar";
        }

        private async void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                ArduinoBLL.ligaDispositivo((i + 1).ToString());
                textBox1.Text = ArduinoBLL.mostraBits(ArduinoBLL.getDisplay());

                await Task.Delay(2000);
            }

            for (int i = 0; i < 8; i++)
            {
                ArduinoBLL.desligaDispositivo((i + 1).ToString());
                textBox1.Text = ArduinoBLL.mostraBits(ArduinoBLL.getDisplay());

                await Task.Delay(2000);
            }
        }
    }
}
