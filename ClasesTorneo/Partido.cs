using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTorneo
{
    public class Partido
    {
        [Key]
        public int Id { get; set; }

        public int TorneoId { get; set; }
        public int RondaId { get; set; }
        public int EquipoLocalId { get; set; }
        public int EquipoVisitanteId { get; set; }

        public DateTime FechaHora { get; set; }

        public bool Jugado { get; set; }

        public int GolesLocal { get; set; }
        public int GolesVisitante { get; set; }

        public int? GanadorId { get; set; }

        public Torneo? Torneo { get; set; }
        public Ronda? Ronda { get; set; }
        public Equipo? EquipoLocal { get; set; }
        public Equipo? EquipoVisitante { get; set; }
        public Equipo? Ganador { get; set; }
        public List<EstadisticaPartido>? Estadisticas { get; set; }
    }
}
