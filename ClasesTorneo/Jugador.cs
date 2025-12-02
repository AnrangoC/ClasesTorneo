using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTorneo
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Nombre { get; set; } = string.Empty; 

        public int EquipoId { get; set; }
        
        public bool EstaSancionado { get; set; } 

        public Equipo? Equipo { get; set; }
        public List<EstadisticaPartido>? Estadisticas { get; set; }
        public List<Sancion>? Sanciones { get; set; }
    }
}
