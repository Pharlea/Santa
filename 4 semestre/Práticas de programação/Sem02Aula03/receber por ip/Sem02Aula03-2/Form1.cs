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
using System.Threading;

namespace Sem02Aula03_2
{
    public partial class Form1 : Form
    {
        Socket socketreceber = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
        EndPoint endereco = new IPEndPoint(IPAddress.Parse("172.16.212.13"), 9060);
        byte[] data = new byte[1024];
        int qtdbytes;
        Thread myThread;
        bool ativaServidor;

        public Form1()
        {
            InitializeComponent();
            socketreceber.Bind(endereco);
        }

       private void button1_Click(object sender, EventArgs e)
        {
            ativaServidor = !ativaServidor;
            

            myThread = new Thread(new ThreadStart(this.mostrarNaTela));

            if (ativaServidor)
            {
                label1.Text = "Receptor Ativo";
            }
            else
            {
                label1.Text = "Receptor Inativo";
            }
            
            myThread.Start();
        }

        private void mostrarNaTela()
        {
            while (ativaServidor)
            {
                qtdbytes = socketreceber.ReceiveFrom(data, ref endereco);

                listBox1.Invoke((Action)delegate ()
                {
                    listBox1.Items.Add(Encoding.ASCII.GetString(data, 0, qtdbytes));
                });                
            }
        }
    }
}
