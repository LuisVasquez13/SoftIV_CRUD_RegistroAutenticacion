using System.Data.SqlClient;

namespace SoftIV_CRUD_RegistroAutenticacion
{
    public static class Conexion
    {
        private static string cadena =
            "Server=localhost; Database=DBAlumnos; Integrated Security=True;";

        public static SqlConnection Conectar()
        {
            return new SqlConnection(cadena);
        }
    }
}
