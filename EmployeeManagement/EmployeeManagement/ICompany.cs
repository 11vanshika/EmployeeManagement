using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    interface ICompany
    {
        int AddDepartment(string deptName);
         int AddEmployee(IEmployee e, out int id);
        int EditEmployee(int employee);
        IEmployee ViewEmployee(int id);
         IEmployee ViewEmployee(string name);
         int DeleteEmployee(int id);
         int ViewDepartment();
         int ViewStatistics(int id);
    }
}
