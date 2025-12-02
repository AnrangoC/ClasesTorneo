using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTorneo
{
    public class Sancion
    {
        [Key]
        public int Id { get; set; }

        public int JugadorId { get; set; }
        public int PartidoOrigenId { get; set; }
        public int PartidoSuspendidoId { get; set; }

        public bool Cumplida { get; set; }

        public Jugador? Jugador { get; set; }
        public Partido? PartidoOrigen { get; set; }
        public Partido? PartidoSuspendido { get; set; }
    }
}
