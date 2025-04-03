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
            int tam, qtd, checkSum = 0;
            String buffer = "", aux = "";
            String filename = "testeXML.xml";

            infile = new System.IO.FileStream(filename,
                                   System.IO.FileMode.Open,
                                   System.IO.FileAccess.Read);

            tam = (int)infile.Length;
            for (int i = 0; i < tam; ++i)
            {
                 buffer += (char)infile.ReadByte();
            }
            infile.Close();

            Socket socketenviar = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
            IPEndPoint endereco = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9060);
            
            Console.ReadKey();
            socketenviar.SendTo(Encoding.ASCII.GetBytes(filename), endereco);
            Console.WriteLine("FileName = " + filename);
            qtd = tam / 10;
            if (tam % 10 != 0) ++ qtd;
            socketenviar.SendTo(Encoding.ASCII.GetBytes(qtd.ToString()), endereco);
            Console.WriteLine("QtdDataGramas = " + qtd);
            for (int i = 0, j = 1; i < tam; ++i, ++j)
            {
                aux += buffer[i];
                checkSum += buffer[i];
                if (j == 10)
                {
                    Console.WriteLine(aux + " | " + checkSum);
                    socketenviar.SendTo(Encoding.ASCII.GetBytes(aux), endereco);
                    socketenviar.SendTo(Encoding.ASCII.GetBytes(checkSum.ToString()), endereco);
                    j = 0;
                    aux = "";
                    checkSum = 0;
                }
            }
            if (tam % 10 != 0)
            {
                Console.WriteLine(aux + " | " + checkSum);
                socketenviar.SendTo(Encoding.ASCII.GetBytes(aux), endereco);
            }
            socketenviar.Close();
            Console.ReadKey();
         }
    }
}
