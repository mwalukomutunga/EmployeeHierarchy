using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeHierarchy
{
  public static  class Extensions
    {
        public static EmployeeHierarchy AsEmployee(this string[] columns, List<IEmployeeHierarchy> employees)
        {
            //Validate data
            ValidateData(columns, employees, out int salary);
            var managerId = columns[1];
            return new EmployeeHierarchy(columns[0], managerId, salary);
        }

        private static void ValidateData(string[] columns, List<IEmployeeHierarchy> employees, out int salary)
        {
            var employeeId = columns[0];
            var managerId = columns[1];
            var sal = columns[1];
            //.Check the salaries in the CSV are valid integer numbers.
            if (!int.TryParse(sal, out salary))
            {
                throw new ArgumentException("Invalid salary field", "Salary");
            }

            //Validate employee Id
            if (string.IsNullOrEmpty(employeeId))
            {
                throw new ArgumentException("Invalid employee field", "EmployeeId");
            }
            //. One employee does not report to more than one manager.


        }
    }
}
