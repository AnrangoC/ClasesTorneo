using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTorneo
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; } = string.Empty;
        public int TorneoId { get; set; }
        public string? Grupo { get; set; }

        public Torneo? Torneo { get; set; }
        public List<Jugador>? Jugadores { get; set; }
        public List<Clasificacion>? Clasificaciones { get; set; }
    }
}
