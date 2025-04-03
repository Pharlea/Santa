using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Mensagens_por_ip
{
    public partial class Form1 : Form
    {
        Socket socketReceber = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
        Socket socketEnviar = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);

        EndPoint enderecoEnviar = new IPEndPoint(IPAddress.Parse("26.152.98.151"), 9060);
        EndPoint enderecoReceber = new IPEndPoint(IPAddress.Parse("26.152.98.151"), 9060);
        byte[] data = new byte[1024];
        int qtBytes;
        Thread  myThread;
        bool servidorAtivo;
       

        public Form1()
        {
            InitializeComponent();
            socketReceber.Bind(enderecoReceber);
        }

        private void bt_LigarServidor_Click(object sender, EventArgs e)
        {
            if (servidorAtivo) { bt_LigarServidor.BackColor = Color.Red; bt_LigarServidor.Text = "Ligar servidor"; }
            else { bt_LigarServidor.BackColor = Color.Lime; bt_LigarServidor.Text = "Desligar servidor"; }

            servidorAtivo = !servidorAtivo;

            myThread = new Thread(new ThreadStart(this.receberMensagens));
            myThread.Start();
        }

        private void receberMensagens()
        {
            while (servidorAtivo)
            {
                qtBytes = socketReceber.ReceiveFrom(data, ref enderecoReceber);

                lb_CaixaDeTexto.Invoke((Action)delegate ()
                {
                    lb_CaixaDeTexto.Items.Add(Encoding.ASCII.GetString(data, 0, qtBytes));
                });               
            }
        }

        private void bt_Enviar_Click(object sender, EventArgs e)
        {
            string texto = tb_Mensagens.Text;

            socketEnviar.SendTo(Encoding.ASCII.GetBytes(texto), enderecoEnviar);
            lb_CaixaDeTexto.Items.Add("Você: " + texto);
        }
    }
}
