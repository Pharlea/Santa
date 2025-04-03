using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroIHM
{
    internal class Livro
    {
        private string titulo;
        private string autor;
        private string editora;
        private string anoedicao;
        private string local;

        public string setTitulo
        {
            set { titulo = value; }
        }
        public string setAutor
        {
            set { autor = value; }
        }
        public string setEditora
        {
            set { editora = value; }
        }
        public string setAnoedicao
        {
            set { anoedicao = value; }
        }
        public string setLocal
        {
            set { local = value; }
        }

        public string getTitulo
        {
            get { return titulo; }
        }
        public string getAutor
        {
            get { return autor; }
        }
        public string getEditora
        {
            get { return editora; }
        }
        public string getAnoedicao
        {
            get { return anoedicao; }
        }
        public string getLocal
        {
            get { return local; }
        }
    }
}
