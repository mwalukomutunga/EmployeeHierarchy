using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeHierarchy
{
  public static  class Extensions
    {
        public static EmployeeHierarchy AsEmployee(this string[] columns)
        {
            var manager = columns[1];
            int.TryParse(columns[2], out int salary);
            return new EmployeeHierarchy(columns[0], manager, salary);
        }
    }
}
