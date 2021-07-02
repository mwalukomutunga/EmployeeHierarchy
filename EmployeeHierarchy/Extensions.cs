using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeHierarchy
{
  public static  class Extensions
    {
        public static EmployeeHierarchy AsEmployee(this string[] columns, List<IEmployeeHierarchy> employees)
        {
            var manager = columns[1];
            ValidateData(columns, employees, out int salary);
            return new EmployeeHierarchy(columns[0], manager, salary);
        }

        private static void ValidateData(string[] columns, List<IEmployeeHierarchy> employees, out int salary)
        {
            throw new NotImplementedException();
        }
    }
}
