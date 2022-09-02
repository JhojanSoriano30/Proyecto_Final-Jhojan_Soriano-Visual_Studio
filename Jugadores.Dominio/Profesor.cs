using System;
using System.Collections.Generic;
using System.Text;

namespace Jugador.Dominio
{
    public class Profesor
    {
        public int ID { get; set; }
        public string Entrenador { get; set; }
        public string Categorias_entrena { get; set; }
        public int NumAlumnos { get; set; }
        public string Equipo { get; set; }
        public int IdEquipo { get; set; }

    }
}
