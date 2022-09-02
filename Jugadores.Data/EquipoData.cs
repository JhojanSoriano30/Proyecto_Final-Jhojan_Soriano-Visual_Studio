using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Jugador.Dominio;

namespace Jugador.Data
{
    public class EquipoData
    {

        string caddenaConexion = "server=PC303\\PAREDES; Database=Final; Integrated Security = true";

        public List<Equipo> ListarCbo()
        {
            var listado = new List<Equipo>();

            using (var conexion = new SqlConnection(caddenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("Select * from Equipo", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Equipo equi;
                            while (lector.Read())
                            {
                                equi = new Equipo();
                                equi.ID = int.Parse(lector[0].ToString());
                                equi.Nombre = lector[1].ToString();

                                listado.Add(equi);

                            }

                        }

                    }

                }

            }

            return listado;
        }




        public List<Equipo> Listar()
        {
            var listado = new List<Equipo>();

            using (var conexion = new SqlConnection(caddenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("select * from Equipo", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Equipo equ;
                            while (lector.Read())
                            {
                                equ = new Equipo();
                                equ.ID = int.Parse(lector[0].ToString());
                                equ.Nombre = lector[1].ToString();
                                equ.FechaInscip = lector[2].ToString();
                                equ.DescripcionT = lector[3].ToString();
                       
                                listado.Add(equ);

                            }

                        }

                    }

                }

            }

            return listado;

        }





        public Equipo BuscarPorId2(int id)
        {
            var equipo = new Equipo();


            using (var conexion = new SqlConnection(caddenaConexion))
            {

                conexion.Open();
                using (var comando = new SqlCommand("Select * from Equipo where IDEq = @id", conexion))
                {

                    comando.Parameters.AddWithValue("@id", id);
                    using (var lector = comando.ExecuteReader())
                    {

                        if (lector != null && lector.HasRows)
                        {
                            lector.Read();
                            equipo = new Equipo();


                            equipo.ID = int.Parse(lector[0].ToString());
                            equipo.Nombre = lector[1].ToString();
                            equipo.FechaInscip = lector[2].ToString();
                            equipo.DescripcionT = lector[3].ToString();
                      

                        }
                    }

                }

            }
            return equipo;
        }


        public Equipo BuscarPorId(int id)
        {
            var equi = new Equipo();
            return equi;
        }






        public bool Insertar(Equipo equipo)
        {
            int filasInsertadas = 0;
            using (var conexion = new SqlConnection(caddenaConexion))
            {
                conexion.Open();
                var sql = "INSERT INTO Equipo (Nombre, Fecha_inscripcion, Despcripcion_torneo)" +
                    "VALUES(@Nombre, @fec, @des)";

                using (var comando = new SqlCommand(sql, conexion))
                {

                    comando.Parameters.AddWithValue("@Nombre", equipo.Nombre);
                    comando.Parameters.AddWithValue("@fec", equipo.FechaInscip);
                    comando.Parameters.AddWithValue("@des", equipo.DescripcionT);

                    filasInsertadas = comando.ExecuteNonQuery();

                }

            }

            return filasInsertadas > 0;
        }







        public bool Actualizar(Equipo equipo)
        {
            int filasActualizadas = 0;
            using (var conexion = new SqlConnection(caddenaConexion))
            {
                conexion.Open();
                var sql = "UPDATE Equipo SET Nombre = @Nombre, Fecha_inscripcion = @fec, " +
                    "Despcripcion_torneo = @des WHERE IDEq = @id";
                using (var comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", equipo.Nombre);
                    comando.Parameters.AddWithValue("@fec", equipo.FechaInscip);
                    comando.Parameters.AddWithValue("@des", equipo.DescripcionT);
                    comando.Parameters.AddWithValue("@id", equipo.ID);

                    filasActualizadas = comando.ExecuteNonQuery();

                }

            }
            return filasActualizadas > 0;
        }








        public bool Eliminar(int id)
        {

            int filasEliminadas = 0;
            using (var conexion = new SqlConnection(caddenaConexion))
            {
                conexion.Open();
                var sql = "DELETE FROM Equipo where IDEq = @id";
                using (var comando = new SqlCommand(sql, conexion))
                {

                    comando.Parameters.AddWithValue("@id", id);
                    filasEliminadas = comando.ExecuteNonQuery();

                }
            }

            return filasEliminadas > 0;
        }




















    }
}
