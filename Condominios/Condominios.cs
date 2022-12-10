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
                    Id = Convert.ToInt32(dr["id_Con"]),
                    Name = dr["nombre"].ToString(),
                    Address = dr["direccion"].ToString(),
                    Phone = dr["tel"].ToString(),
                    Logo = dr["logo"].ToString()
                });
            }
            return condominiosList;
        }

        public static List<Condominium> GetIDCondominio(int Id)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@id_Con", Id)
            };
            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spGetIDCondominio", param);

            List<Condominium> condominio = new List<Condominium>();

            foreach (DataRow dr in ds.Rows)
            {
                condominio.Add(new Condominium()
                {
                    Id = Convert.ToInt64(dr["id_Con"]),
                    Name = dr["nombre"].ToString(),
                    Address = dr["direccion"].ToString(),
                    Phone = dr["tel"].ToString(),
                    Logo = dr["logo"].ToString()
                });
            }
            return condominio;
        }
        public static bool EditCondominio(Condominium condominio)
        {
            try
            {
                List<SqlParameter> param = new List<SqlParameter>()
                {
                    new SqlParameter("@id_Con", condominio.Id),
                    new SqlParameter("@nombre", condominio.Name),
                    new SqlParameter("@direccion", condominio.Address),
                    new SqlParameter("@tel", condominio.Phone),
                    new SqlParameter("@logo",condominio.Logo)
                };
                DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spEditarCondominios", param);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public static bool DeleteCondominio(int Id)
        {
            try
            {
                List<SqlParameter> param = new List<SqlParameter>()
                {
                    new SqlParameter("@id_Con" , Id),
                };
                DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spEliminarCondominios", param);
                return true;
            }
            catch
            {
                return false;
            }
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