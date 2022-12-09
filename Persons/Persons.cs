using System.Data.SqlClient;
using System.Data;
using Proyecto.DatabaseHelper;
using Proyecto.Models;
using System.Diagnostics.Contracts;

namespace Proyecto.Persons
{
    public class Persons
    {
        public static void InserPerson(Person person)
        {
            List<SqlParameter> paramList = new List<SqlParameter>()
            {

                new SqlParameter("id_Rol",person.Id_Rol),
                new SqlParameter("ced",person.Ced),
                new SqlParameter("nombre1",person.FirstName),
                new SqlParameter("nombre2",person.MiddleName),
                new SqlParameter("apellido1",person.LastName2),
                new SqlParameter("apellido2",person.LastName2),
                new SqlParameter("telef",person.Phone),
                new SqlParameter("correo",person.Email),
                new SqlParameter("usuario",person.User),
                new SqlParameter("contra",person.Password)



            };
            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spInsertPersonas", paramList);

        }

        

        public static List<Person> ValidatePerson(String ced, string correo,string tel)
        {
            List<SqlParameter> paramList = new List<SqlParameter>()
            {

                new SqlParameter("usuario",ced),
                new SqlParameter("contra",correo),
                new SqlParameter("usuario",tel),
                


            };


            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spValidarPersonas", paramList);

            List<Person> personList = new List<Person>();
            Person person = new Person();

            foreach (DataRow dr in ds.Rows)
            {
                person.User = dr["usuario"].ToString();
                person.Password = dr["contra"].ToString();
                personList.Add(person);
            }
            return personList;
        }

        public static Person ValidateLoginPerson(String usuario,string contra)
        {
            List<SqlParameter> paramList = new List<SqlParameter>()
            {

                new SqlParameter("usuario",usuario),
                new SqlParameter("contra",contra)


            };


            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spValidarLoginPersonas", paramList);
            
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
