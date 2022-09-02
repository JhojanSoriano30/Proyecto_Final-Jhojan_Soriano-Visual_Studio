using System;
using System.Collections.Generic;
using System.Text;

namespace Jugador.Dominio
{
   public class Jugadores
    {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Categoria { get; set; }
            public int Dni { get; set; }
            public string Profesor { get; set; }
            public string Equipo { get; set; }
            public int IdProfe { get; set; }
            public int IdEquip { get; set; }
    }
}
