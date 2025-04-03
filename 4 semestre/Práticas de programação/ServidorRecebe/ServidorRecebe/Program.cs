using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ServidorRecebe
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socketreceber = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
            EndPoint endereco = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9060);
            byte[] data1 = new byte[1024]; 
            byte[] data2 = new byte[10];
            int  qtdbytes, tam;
            String filename;
           

            socketreceber.Bind(endereco);

            qtdbytes = socketreceber.ReceiveFrom(data1, ref endereco);
            filename = Encoding.ASCII.GetString(data1, 0, qtdbytes);
            Console.WriteLine(filename);

            qtdbytes = socketreceber.ReceiveFrom(data1, ref endereco);
            tam = int.Parse(Encoding.ASCII.GetString(data1, 0, qtdbytes));
            Console.WriteLine(tam);

           

            FileStream outfile;
            outfile = new System.IO.FileStream(filename,
                                                System.IO.FileMode.Create,
                                                System.IO.FileAccess.Write);

            for (int i = 0; i < tam; ++i)
            {
                qtdbytes = socketreceber.ReceiveFrom(data2, ref endereco);
                Console.WriteLine(Encoding.ASCII.GetString(data2, 0, qtdbytes));
                for (int j = 0; j < qtdbytes; ++j)
                {
                    outfile.WriteByte(data2[j]);
                }
                Console.Write(i + " - " + qtdbytes);
            }
            outfile.Close();
            socketreceber.Close();
            Console.ReadKey();
        }
    }
}
