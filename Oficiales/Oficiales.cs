using Proyecto.Models;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto.Oficiales
{
    public class Oficiales
    {

        public static List<Person> GetOficialesPorEmpresas(int empre)
        {

            List<SqlParameter> param = new List<SqlParameter>()
            {

                new SqlParameter("id_Empre",empre),

            };
            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spGetOficialesPorEmpresas", param);

            List<Person> personList = new List<Person>();

            foreach (DataRow dr in ds.Rows)
            {
                personList.Add(new Person
                {
                    Id = Convert.ToInt32(dr["id_Person"]),
                    Id_Rol = Convert.ToInt32(dr["id_Rol"]),
                    Ced = dr["ced"].ToString(),
                    FirstName = dr["nombre1"].ToString(),
                    MiddleName = dr["nombre2"].ToString(),
                    LastName1 = dr["apellido1"].ToString(),
                    LastName2 = dr["apellido2"].ToString(),
                    Phone = dr["telef"].ToString(),
                    Email = dr["correo"].ToString()
                });
            }

            return personList;
        }


    }
}
