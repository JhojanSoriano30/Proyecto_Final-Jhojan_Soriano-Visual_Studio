using System;
using System.Collections.Generic;
using System.Text;
using Jugador.Dominio;
using Jugador.Data;

namespace Jugador.Logic
{
   public static class EquipoBL
    {

        public static List<Equipo> Listarcbo()
        {
            var equi = new EquipoData();
            return equi.ListarCbo();
        }



        public static List<Equipo> Listar()
        {
            var equi = new EquipoData();
            return equi.Listar();
        }


        public static Equipo BuscarPorId2(int id)
        {
            var equi = new EquipoData();
            return equi.BuscarPorId2(id);

        }


        public static bool Insertar(Equipo equipo)
        {

            var equi = new EquipoData();
            return equi.Insertar(equipo);

        }

        public static bool Actualizar(Equipo equipo)
        {

            var equi = new EquipoData();
            return equi.Actualizar(equipo);
        }

        public static bool Eliminar(int id)
        {
            var equi = new EquipoData();
            return equi.Eliminar(id);

        }










    }
}
