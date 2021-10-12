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
        public static ExcelPackage package = new ExcelPackage(new FileInfo("../SourceData/data.xlsx"));
        public static ExcelWorksheet sheet = package.Workbook.Worksheets["List 1"];
    }
    public static class DataController
    {
        public static int GetPeopleCount()
        {
            ExcelWorksheet workSheet = ExcelGlobals.package.Workbook.Worksheets[0];
            var start = workSheet.Dimension.Start;
            var end = workSheet.Dimension.End;
            int peopleCount = 0;
            string cellText = "";

            for (int row = start.Row; row <= end.Row; row++)
            {
                cellText = ExcelGlobals.sheet.Cells[$"A{row}"].Text;

                if (String.IsNullOrEmpty(cellText))
                {
                    peopleCount++;
                }
            }

            return peopleCount;
        }
        public static void ExtractSourceData()
        {
            List<Person> people = new List<Person>();

            using (var package = new ExcelPackage(new FileInfo("../SourceData/data.xlsx")))
            {
                for(int i = 0; i < GetPeopleCount(); i++)
                {
                    string name = ExcelGlobals.sheet.Cells[$"A{i}"].Text;
                    string surname = ExcelGlobals.sheet.Cells["B2"].Text;
                    string employeeId = ExcelGlobals.sheet.Cells["C2"].Text;
                    string department = ExcelGlobals.sheet.Cells["D2"].Text;

                    people.Add(new Person(name, surname, employeeId, department));
                }
            }
        }
    }
}
