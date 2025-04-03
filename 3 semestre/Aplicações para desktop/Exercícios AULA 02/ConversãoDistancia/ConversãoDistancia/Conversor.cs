using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversãoDistancia
{
    internal class Conversor
    {
        public string valor { get; set; }

        public float ConverterParaKm (string _milhas)
        {
            return (float)((float.Parse(_milhas) * 0.60934) + float.Parse(_milhas));               
        }
        public float ConverterParaMilhas(string _km)
        {
            return (float)(float.Parse(_km) / 1.60934);   
        }
    }
}
