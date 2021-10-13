using CaseStudyCSOB.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyCSOB.Controllers
{
    public class ExcelGlobals
    {
        public static ExcelPackage package = new ExcelPackage(new FileInfo("../../../SourceData/data.xlsx"));
        public static ExcelWorksheet sheet = package.Workbook.Worksheets["DATA"];
    }
    public static class DataController
    {
        public static int GetPeopleCount()
        {
            var start = ExcelGlobals.sheet.Dimension.Start.Row;
            var end = ExcelGlobals.sheet.Dimension.End.Row;
            int peopleCount = 0;

            for (int row = start; row <= end; row++)
            {
                if (!String.IsNullOrEmpty(ExcelGlobals.sheet.Cells[$"A{row}"].Text))
                {
                    peopleCount++;
                }
            }

            return peopleCount;
        }
        public static void ExtractSourceData()
        {
            List<Person> people = new List<Person>();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                for(int i = 2; i <= GetPeopleCount(); i++)
                {
                    string name = ExcelGlobals.sheet.Cells[$"A{i}"].Text;
                    string surname = ExcelGlobals.sheet.Cells[$"B{i}"].Text;
                    string employeeId = ExcelGlobals.sheet.Cells[$"C{i}"].Text;
                    string department = ExcelGlobals.sheet.Cells[$"D{i}"].Text;

                    people.Add( new Person( name, surname, employeeId, department, DateTime.Now ));
                }
            foreach(Person person in people)
            {
                DataAccess.InsertPerson(person);
            }
        }
    }
}
