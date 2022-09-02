using System;
using System.Collections.Generic;
using System.Text;
using Jugador.Dominio;
using System.Data.SqlClient;
using System.Data;

namespace Jugador.Data
{
    public class JugadoresData
    {
        string caddenaConexion = "server=PC303\\PAREDES; Database=Final; Integrated Security = true";

        public List<Jugadores> Listar()
        {
            var listado = new List<Jugadores>();

            using (var conexion = new SqlConnection(caddenaConexion))
            {
                conexion.Open();
                using (var comando = new SqlCommand("select Jugadores.ID, Jugadores.Nombre, Jugadores.Apellido, Jugadores.Categoria, Jugadores.Num_DNI, " +
                    "Entrenador.profesor as Profesor, Equipo.Nombre as Equipo from Jugadores inner join Entrenador" +
                    "  on Entrenador.IdProf = Jugadores.IdEntrenador inner join Equipo  on (Equipo.IDEq = Jugadores.IdEquipo); ", conexion))
                {
                    using (var lector = comando.ExecuteReader())
                    {
                        if (lector != null && lector.HasRows)
                        {
                            Jugadores jug;
                            while (lector.Read())
                            {
                                jug = new Jugadores();
                                jug.ID = int.Parse(lector[0].ToString());
                                jug.Nombre = lector[1].ToString();
                                jug.Apellido = lector[2].ToString();
                                jug.Categoria = int.Parse(lector[3].ToString());
                                jug.Dni = int.Parse(lector[4].ToString());
                                jug.Profesor = lector[5].ToString();
                                jug.Equipo = lector[6].ToString();
                                //jug.IdProfe = int.Parse(lector[7].ToString());
                               // jug.IdEquip = int.Parse(lector[8].ToString());
                        

                                listado.Add(jug);

                            }

                        }

                    }

                }

            }

            return listado;

        }



        public Jugadores BuscarPorId(int id)
        {
            var jugad = new Jugadores();


            using (var conexion = new SqlConnection(caddenaConexion))
            {

                conexion.Open();
                using (var comando = new SqlCommand("Select * from Jugadores where ID = @id", conexion))
                {

                    comando.Parameters.AddWithValue("@id", id);
                    using (var lector = comando.ExecuteReader())
                    {

                        if (lector != null && lector.HasRows)
                        {
                            lector.Read();
                            //producto = new Productos();


                            jugad = new Jugadores();
                            jugad.ID = int.Parse(lector[0].ToString());
                            jugad.Nombre = lector[1].ToString();
                            jugad.Apellido = lector[2].ToString();
                            jugad.Categoria = int.Parse(lector[3].ToString());
                            jugad.Dni = int.Parse(lector[4].ToString());
                            jugad.IdProfe = int.Parse(lector[5].ToString());
                             jugad.IdEquip = int.Parse(lector[6].ToString());
                           // jugad.Profesor = lector[5].ToString();
                            //jugad.Equipo = lector[6].ToString();


                        }
                    }

                }

            }
            return jugad;
        }


        public bool Insertar(Jugadores jugad)
        {
            int filasInsertadas = 0;
            using (var conexion = new SqlConnection(caddenaConexion))
            {
                conexion.Open();
                var sql = "INSERT INTO Jugadores(Nombre, Apellido, Categoria,Num_DNI,IdEntrenador,IdEquipo) " +
                    "VALUES(@nombre, @apellido, @categoria, @Ndni, @idEntrena, @idEquipo)";

                using (var comando = new SqlCommand(sql, conexion))
                {

                    comando.Parameters.AddWithValue("@nombre", jugad.Nombre);
                    comando.Parameters.AddWithValue("@apellido", jugad.Apellido);
                    comando.Parameters.AddWithValue("@categoria", jugad.Categoria);
                    comando.Parameters.AddWithValue("@Ndni", jugad.Dni);
                    comando.Parameters.AddWithValue("@idEntrena", jugad.IdProfe);
                    comando.Parameters.AddWithValue("@idEquipo", jugad.IdEquip);

                    filasInsertadas = comando.ExecuteNonQuery();

                }

            }

            return filasInsertadas > 0;
        }


        public bool Actualizar(Jugadores jugad)
        {
            int filasActualizadas = 0;
            using (var conexion = new SqlConnection(caddenaConexion))
            {
                conexion.Open();
                var sql = "UPDATE Jugadores SET Nombre = @nombre, Apellido = @apellido, " +
                    "Categoria = @categoria, Num_DNI = @Ndni, IdEntrenador=@idEntrena," +
                    " IdEquipo=@idEquipo WHERE ID = @idJ";
                using (var comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", jugad.Nombre);
                    comando.Parameters.AddWithValue("@apellido", jugad.Apellido);
                    comando.Parameters.AddWithValue("@categoria", jugad.Categoria);
                    comando.Parameters.AddWithValue("@Ndni", jugad.Dni);
                    comando.Parameters.AddWithValue("@idEntrena", jugad.IdProfe);
                    comando.Parameters.AddWithValue("@idEquipo", jugad.IdEquip);
                    comando.Parameters.AddWithValue("@idJ", jugad.ID);

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
                var sql = "DELETE FROM Jugadores where ID = @id";
                using (var comando = new SqlCommand(sql, conexion))
                {

                    comando.Parameters.AddWithValue("@id", id);
                    filasEliminadas = comando.ExecuteNonQuery();

                }
            }

            return filasEliminadas > 0;
        }

        public bool Buscar(string valor)
        {

            int filasEliminadas = 0;
            using (var conexion = new SqlConnection(caddenaConexion))
            {
                conexion.Open();
                var sql = "select Jugadores.Nombre, Jugadores.Apellido, Jugadores.Categoria, Jugadores.Num_DNI, Entrenador.profesor as Profesor, Equipo.Nombre as Equipo" +
                    " from Jugadores inner join Entrenador  on (Entrenador.IdProf = Jugadores.IdEntrenador)inner " +
                    "join Equipo  on (Equipo.IDEq = Jugadores.IdEquipo) where Jugadores.Nombre like @filtro +'%'";
                using (var comando = new SqlCommand(sql, conexion))
                {

                    comando.Parameters.AddWithValue("@filtro", valor);
                    filasEliminadas = comando.ExecuteNonQuery();

                }
            }

            return filasEliminadas > 0;


        }



   






    }
}
