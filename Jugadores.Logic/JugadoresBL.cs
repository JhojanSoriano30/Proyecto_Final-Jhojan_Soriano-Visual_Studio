using System;
using System.Collections.Generic;
using System.Text;
using Jugador.Dominio;
using Jugador.Data;
using System.Data;

namespace Jugador.Logic
{
   public static class JugadoresBL
    {


        public static List<Jugadores> Listar()
        {
            var jugadoresData = new JugadoresData();
            return jugadoresData.Listar();
        }


        public static Jugadores BuscarPorId(int id)
        {
            var jugadoresData = new JugadoresData();
            return jugadoresData.BuscarPorId(id);
        }


        public static bool Insertar(Jugadores juga)
        {
            var jugadoresData = new JugadoresData();
            return jugadoresData.Insertar(juga);
        }

        public static bool Actualizar(Jugadores juga)
        {
            var jugadoresData = new JugadoresData();
            return jugadoresData.Actualizar(juga);
        }

        public static bool Eliminar(int id)
        {
            var jugadoresData = new JugadoresData();
            return jugadoresData.Eliminar(id);

        }


        public static bool Buscar(string valor)
        {
            var jugadoresData = new JugadoresData();
            return jugadoresData.Buscar(valor);

        }









    }
}
