
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
namespace AppFinalXamarin.Entidades
{
    [DataTable("Clientes")]
    public class Clientes
    {
        [JsonProperty("ID")]
        public string ID { get; set; }

        [JsonProperty("RAZAO")]
        public string Razao { get; set; }
        [JsonProperty("TIPODOCUMENTO")]
        public string TipoDocumento { get; set; }
        [JsonProperty("DOCUMENTO")]

        public string Documento { get; set; }
        [JsonProperty("ENDERECO")]

        public string Endereco { get; set; }
        [JsonProperty("NUMERO")]

        public string Numero { get; set; }
        [JsonProperty("BAIRRO")]

        public string Bairro { get; set; }
        [JsonProperty("CIDADE")]

        public string Cidade { get; set; }
        [JsonProperty("ESTADO")]

        public string Estado { get; set; }
        [JsonProperty("CEP")]

        public string CEP { get; set; }
        [JsonProperty("TELEFONE")]

        public string Telefone { get; set; }

    }
}