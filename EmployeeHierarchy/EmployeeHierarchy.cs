using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeHierarchy
{
   public class EmployeeHierarchy
    {
        public EmployeeHierarchy(string employeeId, string managerId, int salary)
        {
            EmployeeId = employeeId;
            ManagerId = managerId;
            Salary = salary;
            IsCeo = string.IsNullOrEmpty(managerId);
        }
        public string EmployeeId { get; private set; }
        public string ManagerId { get; private set; }
        public int Salary { get; private set; }
        public bool IsCeo { get; private set; }

    }
}
