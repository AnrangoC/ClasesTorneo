using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTorneo
{
    internal class Clasificacion
    {
        public int id;
        public Torneo torneo;
        public Equipo equipo;
        public string Grupo;
        public int Puntos;
        public int PartidosJugados;
        public Jugador jugador;
        public int GolesAFavor;
        public int GolesEnContra;

    }
}
