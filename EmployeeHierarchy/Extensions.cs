using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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
            var sal = columns[2];
            //.Check the salaries in the CSV are valid integer numbers.
            if (!int.TryParse(sal, out salary))
            {
                throw new ArgumentException("Invalid salary field", "Salary");
            }

            //Validate employee Id
            if (string.IsNullOrEmpty(employeeId))
            {
                throw new ArgumentException("Invalid employee id field", "EmployeeId");
            }

            //One employee does not report to more than one manager.
            if (employees.Select(x => x.EmployeeId).Contains(employeeId) && employees.FirstOrDefault(x =>x.EmployeeId ==employeeId).ManagerId !=managerId)
            {
                throw new InvalidDataException("Employee can only have one manager");
            }

            //Validate CEO. There is only one CEO, i.e. only one employee with no manager.
            if (string.IsNullOrEmpty(managerId) && employees.Where(x => x.IsCeo).Count() > 1)
            {
                throw new InvalidDataException("There should be only one CEO");
            }

            //There is no circular reference, i.e. a first employee reporting to a second employee that is also under
            // the first employee.
            //if (employees.Select(x => x.EmployeeId).Contains(employeeId) && employees.FirstOrDefault(x => x.EmployeeId == employeeId).ManagerId != managerId)
            //{
            //    throw new InvalidDataException("Employee should not have circular reference");
            //}
            //There is no manager that is not an employee, i.e. all managers are also listed in the employee
            //column.
            if (!employees.Select(x => x.EmployeeId).Contains(managerId) )
            {
                throw new InvalidDataException("Managers should also be employees");
            }
        }
    }
}
