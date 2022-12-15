using System.Data.SqlClient;
using System.Data;
using Proyecto.DatabaseHelper;
using Proyecto.Models;
using System.Diagnostics.Contracts;

namespace Proyecto.Persons
{
    public class Persons
    {
        public static void InserPerson(Person person,string idEmpre,string idCond,string txtIdCas)
        {   Person person1 = new Person();
            person1=Persons.GetUltimateIdPerson();
            List<SqlParameter> paramList = new List<SqlParameter>()
            {

                new SqlParameter("id_Rol",person.Id_Rol),
                new SqlParameter("id_Empre",idEmpre),
                new SqlParameter("id_Cond",idCond),
                new SqlParameter("ced",person.Ced),
                new SqlParameter("nombre1",person.FirstName),
                new SqlParameter("nombre2",person.MiddleName),
                new SqlParameter("apellido1",person.LastName2),
                new SqlParameter("apellido2",person.LastName2),
                new SqlParameter("telef",person.Phone),
                new SqlParameter("correo",person.Email),
                new SqlParameter("usuario",person.User),
                new SqlParameter("contra",person.Password),
                new SqlParameter("id_ultPerson",person1.Id),
                new SqlParameter("id_Cas",txtIdCas)



            };
            DatabaseHelper.DatabaseHelper.ExecStoreProcedure("spInsertPersonas", paramList);

        }

        public static Person GetUltimateIdPerson()
        {
            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spGetUltimateIdPerson", null);

            Person person = new Person();

            foreach (DataRow dr in ds.Rows)
            {
                person.Id = Convert.ToInt32(dr["id_Person"].ToString());
                

            }
            return person;
        }



        public static List<Person> ValidatePerson(string ced, string correo,string tel)
        {
            List<SqlParameter> paramList = new List<SqlParameter>()
            {

                new SqlParameter("cedula",ced),
                new SqlParameter("correo",correo),
                new SqlParameter("telefono",tel),
                


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


        public static List<Person> ValidateUpdatePerson(string ced, string correo, string tel,int idPeron)
        {
            List<SqlParameter> paramList = new List<SqlParameter>()
            {

                new SqlParameter("cedula",ced),
                new SqlParameter("correo",correo),
                new SqlParameter("telefono",tel),
                new SqlParameter("idPerson",idPeron)



            };
            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spValidarUpdatePersonas", paramList);

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


        public static Person ValidateLoginPerson(string usuario,string contra)
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

        public static void updatePerson(Person person)
        {
            List<SqlParameter> param = new List<SqlParameter>()
            {
                new SqlParameter("id_Person",person.Id),
                new SqlParameter("id_Rol",person.Id_Rol),
                new SqlParameter("ced",person.Ced),
                new SqlParameter("nombre1",person.FirstName),
                new SqlParameter("nombre2",person.MiddleName),
                new SqlParameter("apellido1",person.LastName2),
                new SqlParameter("apellido2",person.LastName2),
                new SqlParameter("telef",person.Phone),
                new SqlParameter("correo",person.Email),
                new SqlParameter("contra",person.Password)


            };

            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spEditarPersona", param);


        }


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
                person.Id =Convert.ToInt32(dr["id_Person"]);
                person.Id_Rol = Convert.ToInt32(dr["id_Rol"]);
                person.Ced = dr["ced"].ToString();
                person.FirstName = dr["nombre1"].ToString();
                person.MiddleName = dr["nombre2"].ToString();
                person.LastName1= dr["apellido1"].ToString();
                person.LastName2 = dr["apellido2"].ToString();
                person.Phone = dr["telef"].ToString();
                person.Email = dr["correo"].ToString();
                person.User= dr["usuario"].ToString();
                person.Password = dr["contra"].ToString();
             }
            return person;
        }


        public static void Delete(string txtIdPers,string txtIdRol)
        {
            List<SqlParameter> paramList = new List<SqlParameter>()
            {

                new SqlParameter("id_Person",txtIdPers),
                new SqlParameter("id_Rol",txtIdRol),

            };
            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("spEliminarPerson", paramList);

        }


    }
}
