using Proyecto.Models;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto.Visitas
{
    public class Visitas
    {

        public static Person GetPerson(int idPerson)
        {
            List<SqlParameter> paramList = new List<SqlParameter>()
            {

                new SqlParameter("idPerson",idPerson),

};


            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spGetPerson", paramList);

            Person person = new Person();

            foreach (DataRow dr in ds.Rows)
            {
                person.Id = Convert.ToInt32(dr["id_Person"]);
                person.Id_Rol = Convert.ToInt32(dr["id_Rol"]);
                person.Ced = dr["ced"].ToString();
                person.FirstName = dr["nombre1"].ToString();
                person.MiddleName = dr["nombre2"].ToString();
                person.LastName1 = dr["apellido1"].ToString();
                person.LastName2 = dr["apellido2"].ToString();
                person.Phone = dr["telef"].ToString();
                person.Email = dr["correo"].ToString();
                person.User = dr["usuario"].ToString();
                person.Password = dr["contra"].ToString();
            }
            return person;
        }
    }
}
