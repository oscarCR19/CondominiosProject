using Proyecto.Models;
using System.Collections.Specialized;
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

        public static List<Condominium> SearchCondominios(string Filtro)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("@filtro", Filtro)
            };
            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spBuscarCondominios", param);

            List<Condominium> condominio = new List<Condominium>();

            foreach (DataRow dr in ds.Rows)
            {
                condominio.Add(new Condominium()
                {
                    Id = Convert.ToInt32(dr["id_Con"]),
                    Name = dr["nombre"].ToString(),
                    Address = dr["direccion"].ToString(),
                    Phone = dr["tel"].ToString(),
                    Logo = dr["logo"].ToString()
                });
            }
            return condominio;
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
                    Id = Convert.ToInt32(dr["id_Con"]),
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
            
            foreach (DataRow dr in ds.Rows)
            {
                condominioList.Add(new Condominium {

                    Id = Convert.ToInt32(dr["id_Con"]),
                    Id_Company = Convert.ToInt32(dr["id_Empre"]),
                    Name = dr["nombre"].ToString(),
                    Address = dr["direccion"].ToString(),
                    Phone = dr["tel"].ToString(),
                    Logo = dr["logo"].ToString()
                });
        }

            return condominioList;
        }

        public static void CrearCasa(string idCond)
        {
            List<SqlParameter> paramList = new List<SqlParameter>()
              {
                 new SqlParameter("idCond",idCond)
            };
         DatabaseHelper.DatabaseHelper.ExecStoreProcedure("spCrearCasa", paramList);

        }

        public static void DeleteCasa(string idCas)
        {
            List<SqlParameter> paramList = new List<SqlParameter>()
              {
                 new SqlParameter("idCas",idCas)
            };
            DatabaseHelper.DatabaseHelper.ExecStoreProcedure("spDeleteCasa", paramList);

        }

        public static List<Apartament> GetCasasPorCondominios(string idCond)
        {
            List<SqlParameter> paramList = new List<SqlParameter>()
              {
                 new SqlParameter("@idCond",idCond),
            };
            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spGetCasasPorCondominios",paramList);

            List<Apartament> casasList = new List<Apartament>();

            foreach (DataRow dr in ds.Rows)
            {
                casasList.Add(new Apartament
                {

                    Id = Convert.ToInt32(dr["id_Cas"]),
                    Id_Condominium= Convert.ToInt32(dr["id_Con"])

                });
            }
            return casasList;
        }

        public static List<Apartament> GetFreeCasasPorCondominios(string idCond)
        {
            List<SqlParameter> param = new List<SqlParameter>()
             {
                 new SqlParameter("iD_Con",idCond)
            };
            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spGetCasasfreePorCond",param);

            List<Apartament> casasList = new List<Apartament>();

            foreach (DataRow dr in ds.Rows)
            {
                casasList.Add(new Apartament
                {

                    Id = Convert.ToInt32(dr["id_Cas"]),
                    Id_Condominium = Convert.ToInt32(dr["id_Con"])

                });
            }
            return casasList;
        }
    }
}