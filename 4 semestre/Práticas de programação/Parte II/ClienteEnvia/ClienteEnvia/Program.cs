using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using Newtonsoft.Json;



namespace ClienteEnvia
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream iofile;
            int tam;
            char x;
            string buffer = "", json;
            Socket socketenviar = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
            IPEndPoint endereco = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9060);
            iofile = new System.IO.FileStream("testeJSON.json",
                                   System.IO.FileMode.Open,
                                   System.IO.FileAccess.ReadWrite);
            tam = (int)iofile.Length;

            for (int i = 0; i < tam; i++)
            {
                x = (char)(iofile.ReadByte());
                buffer += x;
            }

            json = JsonConvert.SerializeObject(buffer);

            socketenviar.SendTo(Encoding.ASCII.GetBytes(json), endereco);
         }
    }
}
