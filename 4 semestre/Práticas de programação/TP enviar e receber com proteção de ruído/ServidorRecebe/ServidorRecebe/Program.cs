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
            byte[] data = new byte[1024], data2 = new byte[1024];
            int qtdbytes, qtdbytes2 = 0, qtd;
            int[] checkSum = new int[1024], checkSumReceived = new int [10];
            String filename;
            bool erro = false;

            socketreceber.Bind(endereco);
            qtdbytes = socketreceber.ReceiveFrom(data, ref endereco);
            Console.WriteLine(Encoding.ASCII.GetString(data, 0, qtdbytes));
            filename = Encoding.ASCII.GetString(data, 0, qtdbytes);

            qtdbytes = socketreceber.ReceiveFrom(data, ref endereco);
            Console.WriteLine(Encoding.ASCII.GetString(data, 0, qtdbytes));
            qtd = int.Parse(Encoding.ASCII.GetString(data, 0, qtdbytes));
            
            FileStream outfile;

            outfile = new System.IO.FileStream(filename,
                                               System.IO.FileMode.Create,
                                               System.IO.FileAccess.Write);

            for (int i = 0; i < qtd; i++)
            {
                qtdbytes = socketreceber.ReceiveFrom(data, ref endereco);
                
                for (int j = 0; j < qtdbytes; j++)
                {
                    checkSum[i] += data[j];
                }

                qtdbytes2 = socketreceber.ReceiveFrom(data2 , ref endereco);

                for (int j = 0; j < qtdbytes2; j++)
                {
                    checkSumReceived[j] = int.Parse(Encoding.ASCII.GetString(data2, 0, qtdbytes2));

                    if (checkSumReceived[j] != checkSum[i])
                    {
                        erro = true;
                    }                    
                }

                if (erro == true)
                {                    
                    Console.WriteLine("Erro ao enviar dados");
                }

                else
                {
                    Console.WriteLine(Encoding.ASCII.GetString(data, 0, qtdbytes));
                    Console.WriteLine(Encoding.ASCII.GetString(data2, 0, qtdbytes2));
                    for (int j = 0; j < qtdbytes; ++j)
                    {
                        outfile.WriteByte((byte)data[j]);
                    }
                }
                erro = false;
            }
            if (qtd % 10 != 0)
            {
                Console.WriteLine(Encoding.ASCII.GetString(data, 0, qtdbytes));
                Console.WriteLine(Encoding.ASCII.GetString(data2, 0, qtdbytes2));
                for (int j = 0; j < qtdbytes; ++j)
                {
                    outfile.WriteByte((byte)data[j]);
                }
            }

            outfile.Close();
            socketreceber.Close();
            Console.ReadKey();
        }
    }
}
