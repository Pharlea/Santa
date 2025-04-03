using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float n1, n2, n3, n4, media;
            n1=float.Parse(textBox1.Text);
            n2=float.Parse(textBox2.Text);  
            n3=float.Parse(textBox3.Text);  
            n4=float.Parse(textBox4.Text);
            media= (n1 + n2 + n3 + n4)/4;
            MessageBox.Show("Media=" + media);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float ang, rad, sen, cos, tan, sec, pi = (float)Math.PI;

            ang=float.Parse(textBox5.Text);
            rad = ang * pi / 180;
            
            sen=(float)Math.Sin(rad);
            cos=(float)Math.Cos(rad);
            tan=(float)Math.Tan(rad);
            sec=(float)1/cos;
            MessageBox.Show("Seno: " + sen + "\nCosseno: " + cos + "\nTangente: " + tan + "\nSecante: " + sec);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float x, y, res;
            x=float.Parse(textBox6.Text);
            y=float.Parse(textBox7.Text);
            res = (float)Math.Pow(x,y);
            MessageBox.Show("Resultado: " + res);
        }
    }
}
