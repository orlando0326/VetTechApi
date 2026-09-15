using System.Text.Json.Serialization

namespace VetTechApi.Models
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CRMV { get; set; }
              
        public string Especialidade { get; set; }

        [JsonIgnore]
        public Consulta? Consulta { get; set; }
    }
}
