using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyCSOB.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmployeeId { get; set; }
        public string Department { get; set; }
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Constructor for the Product model.
        /// </summary>
        /// <param name="id"></param> Database ID
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="employeeId"></param>
        /// <param name="department"></param>
        public Person(string name, string surname, string employeeId, string department, DateTime creationDate)
        {
            Name = name;
            Surname = surname;
            EmployeeId = employeeId;
            Department = department;
            CreationDate = creationDate;
        }
        public string PersonSummary
        {
            get
            {
                return $"{EmployeeId} | {Name} {Surname} ({Department}) | {CreationDate}";
            }
        }
        public Person()
        {

        }
    }
}
