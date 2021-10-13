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

        public static bool CheckEmployeeIdExists(string employeeId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectingString("CaseStudyCSOBDatabase")))
            {
                var output = connection.Query("dbo.People_GetAllByEmployeeId @EmployeeId", new { EmployeeId = employeeId });
                bool response = (output.Count() > 0) ? true : false;
                return response;
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

        public static void InsertPerson(Person person)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectingString("CaseStudyCSOBDatabase")))
            {
                connection.Execute("dbo.People_Insert @Name, @Surname, @EmployeeId, @Department, @CreationDate", person);
            }
        }
    }
}
