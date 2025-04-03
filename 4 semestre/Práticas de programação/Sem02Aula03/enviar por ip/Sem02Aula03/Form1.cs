using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Sem02Aula03
{
    public partial class Form1 : Form
    {
        Socket socketEnviar = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
        IPEndPoint endereco = new IPEndPoint(IPAddress.Parse("172.16.212.14"), 9060);
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_enviar_Click(object sender, EventArgs e)
        {
            string texto;
            texto = textBox1.Text;

            socketEnviar.SendTo(Encoding.ASCII.GetBytes(texto), endereco);
            listBox1.Items.Add(texto);
        }
    }
}
