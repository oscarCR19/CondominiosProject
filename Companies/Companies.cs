using Proyecto.Models;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto.Companies
{
    public class Companies
    {
        public static void InsertCompanie(Company company)
        {
              List<SqlParameter> paramList = new List<SqlParameter>()
              {

                new SqlParameter("nombreEmpresa",company.Name),
                new SqlParameter("direc",company.Location),
                new SqlParameter("tel",company.Phone),
                new SqlParameter("correoEmpresa",company.Email),
                new SqlParameter("logo",company.Logo),
                new SqlParameter("cedJuridica",company.CedJur),
                new SqlParameter("contra",company.Password),


                
              };

            DatabaseHelper.DatabaseHelper.ExecStoreProcedure("", paramList);
        }
        

        //este método valida el registro de una empresa; valida que no se repitan los datos
        public static Company ValidateCompany(string email, string cedJur)
        {
            

            List<SqlParameter> paramList = new List<SqlParameter>()
              {
                 new SqlParameter("correoEmpresa",email),
                 new SqlParameter("cedJuridica",cedJur),
                

            };
            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("", paramList);
            Company company = new Company();
            foreach (DataRow dr in ds.Rows)
            {
                company.Name = dr["nombre"].ToString();
                company.Location = dr["direc"].ToString();
                company.Phone = dr["tel"].ToString();
                company.Email = dr["correo"].ToString();
                company.Logo = dr["logo"].ToString();
                company.CedJur = dr["cedJudiridca"].ToString();
                company.Password = dr["conra"].ToString();
            }

            return company;
        }


        //este metodo valida el login de una empresa
        public static Company ValidateLoginCompany(string correo, string contra)
        {


            List<SqlParameter> paramList = new List<SqlParameter>()
              {
                 new SqlParameter("correo",correo),
                 new SqlParameter("contra",contra),


            };
            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spValidarEmpresas", paramList);
            Company company = new Company();
            foreach (DataRow dr in ds.Rows)
            {
                company.Name = dr["nombre"].ToString();
                company.Location = dr["direc"].ToString();
                company.Phone = dr["tel"].ToString();
                company.Email = dr["correo"].ToString();
                company.Logo = dr["logo"].ToString();
                company.CedJur = dr["cedJuridica"].ToString();
                company.Password = dr["contra"].ToString();
            }

            return company;
        }



    }
}
