csharp TorneoAPI\Data\TorneosDeportivosContext.cs
using Microsoft.EntityFrameworkCore;
using ClasesTorneo;

public class TorneosDeportivosContext : DbContext
{
    public TorneosDeportivosContext(DbContextOptions<TorneosDeportivosContext> options) : base(options)
    {
    }

    public DbSet<Torneo> Torneos { get; set; } = default!;
    public DbSet<Ronda> Rondas { get; set; } = default!;
    public DbSet<Equipo> Equipos { get; set; } = default!;
    public DbSet<Jugador> Jugadores { get; set; } = default!;
    public DbSet<Partido> Partidos { get; set; } = default!;
    public DbSet<EstadisticaPartido> EstadisticasPartido { get; set; } = default!;
    public DbSet<Clasificacion> Clasificaciones { get; set; } = default!;
    public DbSet<Sancion> Sanciones { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Relación Equipo -> Torneo (many Equipos belong to one Torneo)
        modelBuilder.Entity<Equipo>()
            .HasOne(e => e.Torneo)
            .WithMany(t => t.Equipos)
            .HasForeignKey(e => e.TorneoId)
            .OnDelete(DeleteBehavior.Restrict);

        // Relación Torneo -> Campeon (opcional, FK en Torneo)
        modelBuilder.Entity<Torneo>()
            .HasOne(t => t.Campeon)
            .WithMany() // no inverse navigation to avoid ambigüedad
            .HasForeignKey<Torneo>(t => t.CampeonId)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<Partido>()
            .HasOne(p => p.EquipoLocal) 
            .WithMany()
            .HasForeignKey(p => p.EquipoLocalId) 
            .OnDelete(DeleteBehavior.Restrict); 

        modelBuilder.Entity<Partido>()
            .HasOne(p => p.EquipoVisitante) 
            .WithMany()
            .HasForeignKey(p => p.EquipoVisitanteId) 
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Sancion>()
            .HasOne(s => s.PartidoOrigen)
            .WithMany()
            .HasForeignKey(s => s.PartidoOrigenId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Sancion>()
            .HasOne(s => s.PartidoSuspendido)
            .WithMany()
            .HasForeignKey(s => s.PartidoSuspendidoId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Clasificacion>()
            .HasIndex(c => new { c.TorneoId, c.EquipoId })
            .IsUnique();

        base.OnModelCreating(modelBuilder);
    }
}