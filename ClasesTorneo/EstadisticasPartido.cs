using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTorneo
{
    public class EstadisticaPartido
    {
        [Key]
        [Required]
        public string TipoEvento { get; set; } = string.Empty;
        public int? Minuto { get; set; }

        public Partido? Partido { get; set; }
        public Jugador? Jugador { get; set; }
    }
}
