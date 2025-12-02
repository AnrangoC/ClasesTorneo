using System.ComponentModel.DataAnnotations;

namespace ClasesTorneo
{
    public class Torneo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        public string Tipo { get; set; } = string.Empty;
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        [Required]
        public string Estado { get; set; } = "Creado";
        public int? CampeonId { get; set; }
        public Equipo? Campeon { get; set; }
        public List<Equipo>? Equipos { get; set; }
        public List<Ronda>? Rondas { get; set; }
        public List<Partido>? Partidos { get; set; }
        public List<Clasificacion>? Clasificaciones { get; set; }
    }
}
