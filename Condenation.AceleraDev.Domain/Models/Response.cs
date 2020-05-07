using Newtonsoft.Json;

namespace Condenation.AceleraDev.Domain.Models
{
    public class Response
    {
        [JsonProperty("numero_casas")]
        public long NumeroCasas { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("cifrado")]
        public string Cifrado { get; set; }

        [JsonProperty("decifrado")]
        public string Decifrado { get; set; }

        [JsonProperty("resumo_criptografico")]
        public string ResumoCriptografico { get; set; }
    }
}
