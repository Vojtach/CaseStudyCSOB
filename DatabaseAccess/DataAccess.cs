using CaseStudyCSOB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace CaseStudyCSOB
{
    public static class DataAccess
    {
        public static List<Person> GetAllPeople()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectingString("CaseStudyCSOBDatabase")))
            {
                var output = connection.Query<Person>("dbo.People_GetAll").ToList();
                return output;
            }
        }

        public static void DeleteAllPeople()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectingString("CaseStudyCSOBDatabase")))
            {
                connection.Execute("dbo.People_DeleteAll");
            }
        }

        public static void DeletePersonByEmployeeId(string employeeId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectingString("CaseStudyCSOBDatabase")))
            {
                connection.Execute("dbo.People_DeleteByEmployeeId @Id", new { Id = employeeId });
            }
        }

        public static void InsertPerson(string name, string surname, string employeeId, string department)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectingString("CaseStudyCSOBDatabase")))
            {
                List<Person> people = new List<Person>();

                people.Add(new Person { Name = name, Surname = surname, EmployeeId = employeeId, Department = department });

                connection.Execute("dbo.People_Insert @Name, @Surname, @EmployeeId, @Department", people);
            }
        }
    }
}
