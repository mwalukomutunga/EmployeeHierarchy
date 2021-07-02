using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeHierarchy
{
   public class Employees
    {
        private List<IEmployeeHierarchy> employees = new List<IEmployeeHierarchy>();
        public Employees(string csv)
        {
            LoadEmployeeFromCsvString(csv);
        }

        private void LoadEmployeeFromCsvString(string csvString)
        {
            var columns = csvString.Split(',');

        }
    }
}
