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

        #region Public methods
        public Dashboard()
        {
            InitializeComponent();
            UpdatePeopleListbox();
        }
        
        public void UpdatePeopleListbox()
        {
            people = DataAccess.GetAllPeople();
            PeopleListbox.DataSource = people;
            PeopleListbox.DisplayMember = "PersonSummary";
        }

        public void ClearTextFields()
        {
            nameTextBox.Clear();
            SurnameTextBox.Clear();
            EmployeeIdTextBox.Clear();
            DepartmentTextBox.Clear();
        }
        #endregion

        #region Events
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
            WarningLabel.Text = "";
            if (!String.IsNullOrEmpty(nameTextBox.Text) && !String.IsNullOrEmpty(SurnameTextBox.Text) && !String.IsNullOrEmpty(EmployeeIdTextBox.Text) && !DataAccess.CheckEmployeeIdExists(EmployeeIdTextBox.Text) && EmployeeIdTextBox.Text.Length == 6 && !String.IsNullOrEmpty(DepartmentTextBox.Text))
            {
                DataAccess.InsertPerson(new Person(nameTextBox.Text, SurnameTextBox.Text, EmployeeIdTextBox.Text, DepartmentTextBox.Text, DateTime.Now));
                ClearTextFields();
                UpdatePeopleListbox();
            } else if (DataAccess.CheckEmployeeIdExists(EmployeeIdTextBox.Text))
            {
                WarningLabel.Text = "Employee ID already in use.";
            }
            else
            {
                WarningLabel.Text = "Invalid input. Please fill out all employee fields correctly.";
            }
        }
        private void DeletePersonButton_Click(object sender, EventArgs e)
        {
            foreach (var selectedItem in PeopleListbox.SelectedItems)
            {
                string personEmployeeId = PeopleListbox.GetItemText(selectedItem).Substring(0, 6);
                DataAccess.DeletePersonByEmployeeId(personEmployeeId);
            }
            UpdatePeopleListbox();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            DataAccess.DeleteAllPeople();
            DataController.ExtractSourceData();
            UpdatePeopleListbox();
        }

        private void CheckEnableResetButton_CheckedChanged(object sender, EventArgs e)
        {
            ResetButton.Enabled = (CheckEnableResetButton.Checked) ? true : false;
        }

        private void ClearTextFieldsButton_Click(object sender, EventArgs e)
        {
            ClearTextFields();
        }
        #endregion
    }
}
