namespace Proyecto.Models
{
    public class Visita
    {
        public int Id { get; set; }
        public int Id_Cas { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apelliddo2 { get; set; }
        public int id_Mol { get; set; }
        public int id_Veh { get; set; }
        public DateTime Cita { get; set; }
        public string CodeQr{ get; set; }
        public DateTime fechaExp { get; set; }
        public DateTime fechaInic { get; set; }

    }
}
