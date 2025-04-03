using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinemark
{
    internal class CalculaFaturamento
    {
        public CalculaFaturamento()
        {
            numLugares = 0;
        }
        public float numLugares { get; set; }
        public  void calculo()
        {
            Faturamento = this.numLugares * 20;
        }
        public float Faturamento { get; set; }
    }
}
