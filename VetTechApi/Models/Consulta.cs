using Microsoft.VisualBasic;
using System.Data;

namespace VetTechApi.Models
{
    public class Consulta
    {
        public int Id { get; set; }

        public DateAndTime Datahora {  get; set; }

        public string motivo { get; set; }
        public int VeterinarioId { get; set; }

        public int petId { get; set; }

    }
}
