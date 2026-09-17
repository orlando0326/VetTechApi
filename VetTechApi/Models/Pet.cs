using System.Text.Json.Serialization;
 

namespace VetTechApi.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Especie { get; set; }

        public int TutorId { get; set; }

        [JsonIgnore]
        public Consulta? Consulta { get; set; }
    }
}