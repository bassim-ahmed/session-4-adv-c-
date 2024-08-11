using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static assignment_4_adv_c_.Employee;

namespace assignment_4_adv_c_
{
    public class Club
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }
        private List<Employee> Members = new List<Employee>();

        public void AddMember(Employee e)
        {
            Members.Add(e);
            e.EmployeeLayOff += RemoveMember;
        }

        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            var employee = sender as Employee;
            if (employee != null && e.Cause == LayOffCause.VacationStockNegative)
            {
                Members.Remove(employee);
                Console.WriteLine($"Employee {employee.EmployeeID} removed from club due to {e.Cause}");
            }
        }
    }

}
