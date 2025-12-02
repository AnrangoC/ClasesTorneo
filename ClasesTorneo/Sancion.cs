using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesTorneo
{
    internal class Sancion
    {
        public int id;
        public Jugador jugador;
        public Partido partido;
        public string tipo; // Ejemplo: "Tarjeta Amarilla", "Tarjeta Roja"
        public string descripcion;
        public string Estado;
    }
}
