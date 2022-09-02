using System;
using System.Collections.Generic;
using System.Text;
using Jugador.Dominio;
using System.Data.SqlClient;

namespace Jugador.Data
{
   public  class ProfesorData
    {
        string caddenaConexion = "server=PC303\\PAREDES; Database=Final; Integrated Security = true";

        public List<Profesor> Listarcbo()
        {
            var listado = new List<Profesor>();

            using (var conexion = new SqlConnection(caddenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("Select * from Entrenador", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Profesor pro;
                            while (lector.Read())
                            {
                                pro = new Profesor();
                                pro.ID = int.Parse(lector[0].ToString());
                                pro.Entrenador = lector[1].ToString();

                                listado.Add(pro);

                            }

                        }

                    }

                }

            }

            return listado;
        }



        public List<Profesor> Listar()
        {
            var listado = new List<Profesor>();

            using (var conexion = new SqlConnection(caddenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("select Entrenador.IdProf, Entrenador.Profesor, Entrenador.Categorias_que_entrena, Entrenador.Numero_alumnos," +
                    " Equipo.Nombre as Equipo from Entrenador inner join Equipo  on Entrenador.IDEq = Equipo.IDEq ", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Profesor prof;
                            while (lector.Read())
                            {
                                prof = new Profesor();
                                prof.ID = int.Parse(lector[0].ToString());
                                prof.Entrenador = lector[1].ToString();
                                prof.Categorias_entrena = lector[2].ToString();
                                prof.NumAlumnos = int.Parse(lector[3].ToString());
                                prof.Equipo = lector[4].ToString();
         


                                listado.Add(prof);

                            }

                        }

                    }

                }

            }

            return listado;

        }










        public Profesor BuscarPorId(int id)
        {
            var prof = new Profesor();


            using (var conexion = new SqlConnection(caddenaConexion))
            {

                conexion.Open();
                using (var comando = new SqlCommand("Select * from Entrenador where IdProf = @id", conexion))
                {

                    comando.Parameters.AddWithValue("@id", id);
                    using (var lector = comando.ExecuteReader())
                    {

                        if (lector != null && lector.HasRows)
                        {
                            lector.Read();

                            prof = new Profesor();
                            prof.ID = int.Parse(lector[0].ToString());
                            prof.Entrenador = lector[1].ToString();
                            prof.Categorias_entrena = lector[2].ToString();
                            prof.NumAlumnos = int.Parse(lector[3].ToString());
                            prof.IdEquipo = int.Parse(lector[4].ToString());


                        }
                    }

                }

            }
            return prof;
        }

        public bool Insertar(Profesor profesor)
        {
            int filasInsertadas = 0;
            using (var conexion = new SqlConnection(caddenaConexion))
            {
                conexion.Open();
                var sql = "INSERT INTO Entrenador(Profesor, Categorias_que_entrena, Numero_alumnos,IDEq) " +
                    "VALUES(@nombre, @cat, @num, @idEquipo)";

                using (var comando = new SqlCommand(sql, conexion))
                {

                    comando.Parameters.AddWithValue("@nombre", profesor.Entrenador);
                    comando.Parameters.AddWithValue("@cat", profesor.Categorias_entrena);
                    comando.Parameters.AddWithValue("@num", profesor.NumAlumnos);
                    comando.Parameters.AddWithValue("@idEquipo", profesor.IdEquipo);
  

                    filasInsertadas = comando.ExecuteNonQuery();

                }

            }

            return filasInsertadas > 0;
        }


        public bool Actualizar(Profesor profesor)
        {
            int filasActualizadas = 0;
            using (var conexion = new SqlConnection(caddenaConexion))
            {
                conexion.Open();
                var sql = "UPDATE Entrenador SET Profesor = @profe, Categorias_que_entrena = @cat, " +
                    "Numero_alumnos = @num, IDEq = @idq" +
                    " WHERE IdProf = @idp";
                using (var comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@profe", profesor.Entrenador);
                    comando.Parameters.AddWithValue("@cat", profesor.Categorias_entrena);
                    comando.Parameters.AddWithValue("@num", profesor.NumAlumnos);
                    comando.Parameters.AddWithValue("@idq", profesor.IdEquipo);
            
                    comando.Parameters.AddWithValue("@idp", profesor.ID);

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
                var sql = "DELETE FROM Entrenador where IdProf = @id";
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
