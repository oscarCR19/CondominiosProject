namespace MVCondominios.Models
{
    public class User
    {
        public int IdEstudiante { get; set; }
        public string? NombreCompleto { get; set; }
        public string? Cedula { get; set; }
        public string? NombreUsuario { get; set; }
        public string? Password { get; set; }
        public int IdRol { get; set; }
    }
}
