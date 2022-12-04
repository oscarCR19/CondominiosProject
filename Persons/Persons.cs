using System.Data.SqlClient;
using System.Data;
using Proyecto.DatabaseHelper;
using Proyecto.Models;

namespace Proyecto.Persons
{
    public class Persons
    {
        public void InserPerson()
        {
           
        }

        public void GetPerson()
        {
            //Codigo a desarrollar
            //Llamados a databate con sus respectivos sp
        }

        public static Person ValidatePerson(String usuario,string contra)
        {
            List<SqlParameter> paramList = new List<SqlParameter>()
            {

                new SqlParameter("usuario",usuario),
                new SqlParameter("contra",contra)


            };


            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spValidarPersonas", paramList);
            
            Person person = new Person();

            foreach (DataRow dr in ds.Rows)
            {
                person.User = dr["usuario"].ToString();
                person.Password = dr["contra"].ToString();
             
            }
            return person;
        }

    }
}
