using System;
using System.Collections.Generic;
using System.Text;
using Jugador.Dominio;
using Jugador.Data;

namespace Jugador.Logic
{
    public static class ProfesorBL
    {

        public static List<Profesor> ListarCbo()
        {
            var pro = new ProfesorData();
            return pro.Listarcbo();
        }


        public static List<Profesor> Listar()
        {
            var profe = new ProfesorData();
            return profe.Listar();
        }


        public static Profesor BuscarPorId(int id)
        {
            var profe = new ProfesorData();
            return profe.BuscarPorId(id);

        }


        public static bool Insertar(Profesor pro)
        {

            var profe = new ProfesorData();
            return profe.Insertar(pro);

        }

        public static bool Actualizar(Profesor pro)
        {

            var profe = new ProfesorData();
            return profe.Actualizar(pro);
        }

        public static bool Eliminar(int id)
        {
            var profe = new ProfesorData();
            return profe.Eliminar(id);

        }



    }
}
