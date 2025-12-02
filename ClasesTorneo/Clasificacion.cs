using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTorneo
{
    public class Clasificacion
    {
        [Key]
        public int Id { get; set; }
        public int TorneoId { get; set; }
        public int EquipoId { get; set; }
        public string? Grupo { get; set; }
        public int Puntos { get; set; }
        public int PartidosJugados { get; set; }
        public int GolesFavor { get; set; }
        public int GolesContra { get; set; }
        public int DiferenciaGoles { get; set; }
        public Torneo? Torneo { get; set; }
        public Equipo? Equipo { get; set; }
    }
} 
}
