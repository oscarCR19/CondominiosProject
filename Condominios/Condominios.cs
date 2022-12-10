using Proyecto.Models;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Condominios
{
    public class Condominios
    {
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

        //Metodo para obtener los condominios de determinada empresa
        public static List<Condominium> getListCondomonios(int idEmpre)
        {
            List<SqlParameter> paramList = new List<SqlParameter>()
              {
                 new SqlParameter("id",idEmpre),



            };
            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spGetCondominiosPorEmpresas", paramList);

            List<Condominium> condominioList = new List<Condominium>();
            Condominium condominio = new Condominium();

            foreach (DataRow dr in ds.Rows)
            {
                condominio.Id = Convert.ToInt32(dr["id_Con"]);
                condominio.Id_Company = Convert.ToInt32(dr["id_Empre"]);
                condominio.Name = dr["nombre"].ToString();
                condominio.Address = dr["direccion"].ToString();
                condominio.Phone = dr["tel"].ToString();
                condominio.Logo = dr["logo"].ToString();
                condominioList.Add(condominio);
            }

            return condominioList;
        }


    }
}