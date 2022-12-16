using Proyecto.Models;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto.Visitas
{
    public class Visitas
    {

        public static List<Visita> GetVisita(string txtUser)
        {
            List<SqlParameter> paramList = new List<SqlParameter>()
            {

                new SqlParameter("usuario",txtUser),

            };


            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spGetVisitasPorPersonas", paramList);

            Visita visita= new Visita();
            List<Visita> listVistas= new List<Visita>();  
            foreach (DataRow dr in ds.Rows)
            {
                listVistas.Add( new Visita { 
                Id = Convert.ToInt32(dr["id_Vis"]),
                Nombre = dr["nombre"].ToString(),
                Apellido1 = dr["apellido1"].ToString(),
                Cita = (DateOnly)(dr["cita"]),
                CodeQr = dr["cod_QR"].ToString(),
                Placa = dr["placa"].ToString(),
                RutaCodeQr = dr["ruta_QR"].ToString(),
                Color = dr["col_Vehic"].ToString()
            });
        }
            return listVistas;
        }

        public static void CrearVisita(Visita visita)
        {
            List<SqlParameter> paramList = new List<SqlParameter>()
            {

                new SqlParameter("nombre",visita.Nombre),
                new SqlParameter("apellido1",visita.Placa),
                new SqlParameter("placa",visita.Placa),
                new SqlParameter("col_Vehic",visita.Color),
                new SqlParameter("cita",visita.Cita),
                new SqlParameter("code_QR",visita.CodeQr)


            };


            DatabaseHelper.DatabaseHelper.ExecStoreProcedure("spCrearVisita", paramList);

            
        }
    }
}
