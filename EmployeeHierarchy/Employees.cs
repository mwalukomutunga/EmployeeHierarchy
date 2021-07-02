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
        /// <summary>
        /// Load Csv string
        /// </summary>
        /// <param name="csvString"></param>
        private void LoadEmployeeFromCsvString(string csvString)
        {
            var columns = csvString.Split(',');
            employees.Add(columns.AsEmployee(employees));
        }

        /// <summary>
        /// Gets all employeees and their hierarchy
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IEmployeeHierarchy> GetEmployeeHierarchy()
        {
            return employees;
        }
    }
}
