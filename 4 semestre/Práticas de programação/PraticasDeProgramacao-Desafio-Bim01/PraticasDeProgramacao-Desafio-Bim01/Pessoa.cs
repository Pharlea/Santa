using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticasDeProgramacao_Desafio_Bim01
{
    internal class Pessoa
    {
        public static int? id {  get; set; }
        public static string nome { get; set; }
        public static string telefone { get; set; }
        public static string eMail { get; set; }
        public static string cep { get; set; }
        [JsonProperty("estado")]
        public static string estado { get; set; }
        [JsonProperty("localidade")]
        public static string cidade { get; set; }
        [JsonProperty("bairro")]
        public static string bairro { get; set; }
        [JsonProperty("logradouro")]
        public static string rua { get; set; }
        public static string numero { get; set; }
        public static string complemento {  get; set; }
    }
}
