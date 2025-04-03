using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Newtonsoft.Json;

namespace ServidorRecebe
{
    class Program
    {
        static void Main(string[] args)
        {
            string json;
            FileStream iofile;
            Socket socketreceber = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
            EndPoint endereco = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9060);
            byte[] data = new byte[1024];
            int  qtdbytes;
            iofile = new System.IO.FileStream(@"C:\Users\Unisanta\Downloads\testeJSON.json",
                                  System.IO.FileMode.Create,
                                  System.IO.FileAccess.Write);

            socketreceber.Bind(endereco);
            while (true)
            {
                qtdbytes = socketreceber.ReceiveFrom(data, ref endereco);
                
                for (int i = 0; i < qtdbytes; i++)
                {
                    iofile.WriteByte(data[i]);
                }
                iofile.Close();
            }

            

        }
    }
}
