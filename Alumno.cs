namespace SoftIV_CRUD_RegistroAutenticacion
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Carrera { get; set; }
        public string Semestre { get; set; }
        public string Jornada { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public bool RecibirNotificaciones { get; set; }
        public string FechaRegistro { get; set; }
    }
}
