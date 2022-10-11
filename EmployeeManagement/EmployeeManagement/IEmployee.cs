using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    interface IEmployee
    {
        int EmployeeDepID { get; set; }
        int EmployeeID { get; set; }
        string FullName { get; set; }
        DateTime DateOfBirth { get; set; }
        int Experience { get; set; }
        string Designation { get; set; }
        int BasicPay { get; set; }
        int GrossPay { get; set; }
    }
}
