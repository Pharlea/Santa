using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ClienteEnvia
{
    class Program
    {
        static void Main(string[] args)
        {
 
            FileStream infile;
            int tam;
            String buffer = "";
            String filename = "teste.xml";
            string tamanho;

            Socket socketenviar = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
            IPEndPoint endereco = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9060);

            infile = new System.IO.FileStream(filename,
                                   System.IO.FileMode.Open,
                                   System.IO.FileAccess.Read);

            tam = (int)infile.Length;
            tamanho = "" + tam;
            float qnt = tam / 10f;

            socketenviar.SendTo(Encoding.ASCII.GetBytes(filename),endereco);
            //Console.WriteLine(filename);
            socketenviar.SendTo(Encoding.ASCII.GetBytes(Math.Ceiling(qnt).ToString()), endereco);
            //Console.WriteLine(Math.Ceiling(qnt).ToString());
            
            for (int i = 0, j = 0; i < tam; ++i, j++)
            {
                buffer += (char)infile.ReadByte();
                if (j == 10)
                {
                    
                    socketenviar.SendTo(Encoding.ASCII.GetBytes(buffer), endereco);
                    //Console.WriteLine(buffer);
                    j = 0;
                    buffer = "";
                }
            }
            if (buffer != "")
            {
                socketenviar.SendTo(Encoding.ASCII.GetBytes(buffer), endereco);
                //Console.WriteLine(buffer);
            }
            infile.Close();
            
            socketenviar.Close();
            Console.ReadKey();
         }
    }
}
