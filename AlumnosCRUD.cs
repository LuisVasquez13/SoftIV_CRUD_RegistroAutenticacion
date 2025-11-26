using System;
using System.Data;
using System.Data.SqlClient;

namespace SoftIV_CRUD_RegistroAutenticacion
{
    public class AlumnosCRUD
    {
        // READ
        public static DataTable ObtenerTodos()
        {
            using (SqlConnection cn = Conexion.Conectar())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Alumnos ORDER BY FechaRegistro DESC", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // CREATE
        public static void Insertar(Alumno a)
        {
            using (SqlConnection cn = Conexion.Conectar())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO Alumnos
                    (Nombre, Cedula, Carrera, Semestre, Jornada, Usuario, Contrasena, RecibirNotificaciones)
                    VALUES (@n,@c,@ca,@s,@j,@u,@co,@r)", cn);

                cmd.Parameters.AddWithValue("@n", a.Nombre);
                cmd.Parameters.AddWithValue("@c", a.Cedula);
                cmd.Parameters.AddWithValue("@ca", a.Carrera);
                cmd.Parameters.AddWithValue("@s", a.Semestre);
                cmd.Parameters.AddWithValue("@j", a.Jornada);
                cmd.Parameters.AddWithValue("@u", a.Usuario);
                cmd.Parameters.AddWithValue("@co", a.Contrasena);
                cmd.Parameters.AddWithValue("@r", a.RecibirNotificaciones);

                cmd.ExecuteNonQuery();
            }
        }

        // UPDATE
        public static void Actualizar(Alumno a)
        {
            using (SqlConnection cn = Conexion.Conectar())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(@"
                    UPDATE Alumnos SET
                    Nombre=@n, Cedula=@c, Carrera=@ca, Semestre=@s,
                    Jornada=@j, Usuario=@u, Contrasena=@co,
                    RecibirNotificaciones=@r
                    WHERE Id=@id", cn);

                cmd.Parameters.AddWithValue("@id", a.Id);
                cmd.Parameters.AddWithValue("@n", a.Nombre);
                cmd.Parameters.AddWithValue("@c", a.Cedula);
                cmd.Parameters.AddWithValue("@ca", a.Carrera);
                cmd.Parameters.AddWithValue("@s", a.Semestre);
                cmd.Parameters.AddWithValue("@j", a.Jornada);
                cmd.Parameters.AddWithValue("@u", a.Usuario);
                cmd.Parameters.AddWithValue("@co", a.Contrasena);
                cmd.Parameters.AddWithValue("@r", a.RecibirNotificaciones);

                cmd.ExecuteNonQuery();
            }
        }

        // DELETE
        public static void Eliminar(int id)
        {
            using (SqlConnection cn = Conexion.Conectar())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Alumnos WHERE Id=@id", cn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        // Buscar alumno por cédula
        public static DataTable BuscarCedula(string ced)
        {
            using (SqlConnection cn = Conexion.Conectar())
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM Alumnos WHERE Cedula=@c", cn);

                da.SelectCommand.Parameters.AddWithValue("@c", ced);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
