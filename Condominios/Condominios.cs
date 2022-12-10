using Proyecto.Models;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Condominios
{
    public class Condominios
    {
        public static bool CreateCondominio(Condominium condominio)
        {
            try
            {
                List<SqlParameter> param = new List<SqlParameter>()
                {
                    new SqlParameter("id_Empre" , condominio.Id_Company),
                    new SqlParameter("nombre", condominio.Name),
                    new SqlParameter("direccion", condominio.Address),
                    new SqlParameter("tel", condominio.Phone),
                    new SqlParameter("logo",condominio.Logo)
                };
                DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spCrearCondominios", param);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static List<Condominium> GetCondominios()
        {
            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spGetCondominios", null);

            List<Condominium> condominiosList = new List<Condominium>();

            foreach (DataRow dr in ds.Rows)
            {
                condominiosList.Add(new Condominium()
                {
                    Name = dr["nombre"].ToString(),
                    Address = dr["direccion"].ToString(),
                    Phone = dr["tel"].ToString(),
                    Logo = dr["logo"].ToString()
                });
            }
            return condominiosList;
        }
    }
}