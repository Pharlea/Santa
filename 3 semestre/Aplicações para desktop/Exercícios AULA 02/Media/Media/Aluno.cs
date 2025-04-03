using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    internal class Aluno
    {
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string P3 { get; set;}
        public string P4 { get; set;}

        public string GetMedia(string p1, string p2, string p3, string p4)
        {
            float media = ((float.Parse(p1) + float.Parse(p2) + float.Parse(p3)+ float.Parse(p4)) / 4);
            return media.ToString();
        }
    }
}
