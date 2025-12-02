using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTorneo
{
    internal class Partido
    {
        public int id;
        public Ronda ronda;
        public EstadisticasPartido estadisticas;
        public List<Sancion> sanciones;
    }
}
