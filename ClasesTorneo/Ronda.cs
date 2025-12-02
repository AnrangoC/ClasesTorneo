using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTorneo
{
    public class Ronda
    {
        [Key]
        public int Id { get; set; }

        public int TorneoId { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;

        public int Orden { get; set; }

        [Required]
        public string TipoFase { get; set; } = string.Empty;

        public bool EstaCompleta { get; set; }

        public Torneo? Torneo { get; set; }
        public List<Partido>? Partidos { get; set; }
    }
}
