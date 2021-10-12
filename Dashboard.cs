using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaseStudyCSOB.Models;
using CaseStudyCSOB.Controllers;

namespace CaseStudyCSOB
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();
        }
        
        public void UpdatePeopleListbox()
        {
            people = DataAccess.GetAllPeople();
            PeopleListbox.DataSource = people;
            PeopleListbox.DisplayMember = "PersonSummary";
        }

        private void PeopleListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SurnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepartmentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatePersonButton_Click(object sender, EventArgs e)
        {

        }
        private void DeletePersonButton_Click(object sender, EventArgs e)
        {
            foreach (string personSummary in PeopleListbox.SelectedItems)
            {
                string personEmployeeId = personSummary.Substring(0, 5);
                DataAccess.DeletePersonByEmployeeId(personEmployeeId);
            }
            UpdatePeopleListbox();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            DataAccess.DeleteAllPeople();
            DataController.ExtractSourceData();
        }

    }
}
