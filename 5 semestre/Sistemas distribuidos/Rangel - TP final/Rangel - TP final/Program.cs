using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class SingletonUF
    {
        private SingletonUF()
        {
            //
        }
        private List<UF> lista = new List<UF>();

        public void AddUF(UF uf)
        {
            lista.Add(uf);
        }
        public List<UF> getLista()
        {
            return lista;
        }
        public void sortList()
        {
            lista.Sort();
        }
        public static class UFHolder
        {
            public static SingletonUF uf = new SingletonUF();
        }
        public static SingletonUF getUF()
        {
            return SingletonUF.UFHolder.uf;
        }
    }
    public class UF : IComparable<UF>
    {
        String estado { get; set; }
        String sigla { get; set; }
        String capital { get; set; }
        String ddd { get; set; }
        public UF(String estado, String sigla, String capital, String ddd)
        {
            this.estado = estado;
            this.sigla = sigla;
            this.capital = capital;
            this.ddd = ddd;
        }

        public String getSigla()
        {
            return sigla;
        }

        public String getEstado()
        {
            return estado;
        }

        public String getCapital()
        {
            return capital;
        }

        public String getDdd()
        {
            return ddd;
        }

        public int CompareTo(UF other)
        {
            if (other == null) return 1;
            return this.sigla.CompareTo(other.sigla);
        }
    }
    public class SiglaComparer : IComparer<UF>
    {
        public int Compare(UF? x, UF? y)
        {
            if (x == null || y == null) return 0;
            return x.getSigla().CompareTo(y.getSigla());
        }

    }

    class Program
    {
        public static UF busca(String sigla)
        {
            SingletonUF singleton = SingletonUF.getUF();
            UF uf = new UF("", sigla, "", "");

            List<UF> lista = new List<UF>();
            lista = singleton.getLista();

            int index = lista.BinarySearch(uf, new SiglaComparer());

            return lista[index];
        }
        static public void popula(String[,] _uf)
        {
            SingletonUF singleton = SingletonUF.getUF();            
            for (int i = 0; i < _uf.GetLength(0); i++)
            {
                UF uF = new UF(_uf[i, 0], _uf[i, 1], _uf[i, 2], _uf[i, 3]);
                singleton.AddUF(uF);
            }
            singleton.sortList();
        }
        static void Main(string[] args)
        {
            String[,] uf = {
                            {"Rio Grande do Norte","RN","Natal", "84"},
                            {"Distrito Federal","DF","Brasília", "61"},
                            {"Espírito Santo","ES","Vitória", "27"},
                            {"Goiás","GO","Goiânia", "62"},
                            {"Piauí","PI","Teresina", "86"},
                            {"Rio de Janeiro","RJ","Rio de Janeiro", "21"},
                            {"Rondônia","RO","Porto Velho", "69"},
                            {"Amazonas","AM","Manaus", "92"},
                            {"Bahia","BA","Salvador", "71"},
                            {"Rio Grande do Sul","RS","Porto Alegre", "51"},
                            {"Ceará","CE","Fortaleza", "85"},
                            {"Santa Catarina","SC","Florianópolis", "48"},
                            {"São Paulo","SP","São Paulo", "11"},
                            {"Sergipe","SE","Aracaju", "79"},
                            {"Mato Grosso do Sul","MS","Campo Grande", "67"},
                            {"Minas Gerais","MG","Belo Horizonte", "31"},
                            {"Pará","PA","Belém", "91"},
                            {"Paraíba","PB","João Pessoa", "83"},
                            {"Paraná","PR","Curitiba", "41"},
                            {"Pernambuco","PE","Recife", "81"},
                            {"Roraima","RR","Boa Vista", "95"},
                            {"Tocantins","TO","Palmas", "63"},
                            {"Maranhão","MA","São Luís", "98"},
                            {"Mato Grosso","MT","Cuiabá", "65"},
                            {"Acre","AC","Rio Branco", "68"},
                            {"Alagoas","AL","Maceió", "82"},
                            {"Amapá","AP","Macapá", "96"},
                        };

            popula(uf);

            Console.Write("Escreva a sigla que você deseja pesquisar: ");
            String sigla = Console.ReadLine();

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n", busca(sigla).getEstado(), busca(sigla).getSigla(), busca(sigla).getCapital(), busca(sigla).getDdd());
        }
    }
}


