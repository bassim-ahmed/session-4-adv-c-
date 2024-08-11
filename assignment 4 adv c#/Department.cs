using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static assignment_4_adv_c_.Employee;

namespace assignment_4_adv_c_
{
    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        private List<Employee> Staff = new List<Employee>();

        public void AddStaff(Employee e)
        {
            Staff.Add(e);
            e.EmployeeLayOff += RemoveStaff;
        }

        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            var employee = sender as Employee;
            if (employee != null)
            {
                Staff.Remove(employee);
                Console.WriteLine($"Employee {employee.EmployeeID} removed from department due to {e.Cause}");
            }
        }
    }

}
