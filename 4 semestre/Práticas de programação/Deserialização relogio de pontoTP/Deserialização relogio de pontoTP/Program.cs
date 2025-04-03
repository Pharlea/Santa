using System.Xml.Serialization;
using System.IO;

namespace Deserialização_relogio_de_pontoTP
{
    class program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();

            System.IO.StreamReader file = new System.IO.StreamReader("Abril 2017.txt");
            OcorrenciaPonto ocorrencia = new OcorrenciaPonto();
            List<OcorrenciaPonto> ocorrencias = new List<OcorrenciaPonto>();
            XmlSerializer obj = new XmlSerializer(ocorrencias.GetType());
            TextWriter arquivo = new StreamWriter("Abril 2017.xml");

            string? aux;
            bool erro = false;
            int j = 0;

            
            while (!erro)
            {               
                aux = file.ReadLine();

                if (aux is not null)
                {
                    for (int i = 0; i < 15; i++)
                        ocorrencia.pontuario += aux[i];

                    for (int i = 0; i < 6; i++)
                        ocorrencia.data += aux[i + 15];

                    for (int i = 0; i < 4; i++)
                        ocorrencia.hora += aux[i + 21];

                    for (int i = 0; i < 8; i++)
                        ocorrencia.filler += aux[i + 25];

                    Console.WriteLine("pontuário: {0}\ndata: {1}\nhora: {2}\nfiller: {3}", ocorrencia.pontuario, ocorrencia.data, ocorrencia.hora, ocorrencia.filler);

                    ocorrencias.Add(new OcorrenciaPonto());
                    ocorrencias[j].pontuario = ocorrencia.pontuario;
                    ocorrencias[j].data = ocorrencia.data;
                    ocorrencias[j].hora = ocorrencia.hora;
                    ocorrencias[j].filler = ocorrencia.filler;

                    ++j;
                }
                else
                {
                    erro = true;
                }
                aux = "";
                ocorrencia.pontuario = null;
                ocorrencia.filler = null;
                ocorrencia.hora = null;
                ocorrencia.data = null;
            }

            Console.WriteLine(ocorrencias.Count);
            Console.WriteLine(ocorrencias[0].pontuario);
            obj.Serialize(arquivo, ocorrencias);
            arquivo.Close();
            Console.ReadKey();
        }
    }
}