using static assignment_4_adv_c_.Employee;

namespace assignment_4_adv_c_
{
    public class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }

        public bool CheckTarget(int quota)
        {
            if (AchievedTarget < quota)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.FailedSalesTarget });
                return false;
            }
            return true;
        }
    }


    public class BoardMember : Employee
    {
        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.Resigned });
        }
    }




    internal class Program
    {
    

        static void Main(string[] args)
        {

            // Create employees
            Employee emp1 = new Employee { EmployeeID = 1, BirthDate = new DateTime(2023, 1, 1), VacationStock = -5 };
            Employee emp2 = new Employee { EmployeeID = 2, BirthDate = new DateTime(2020, 5, 15), VacationStock = 10 };
            SalesPerson salesPerson = new SalesPerson { EmployeeID = 3, BirthDate = new DateTime(2022, 7, 20), AchievedTarget = 50 };
            BoardMember boardMember = new BoardMember { EmployeeID = 4, BirthDate = new DateTime(2022, 3, 10) };

            // Create department and club
            Department dept = new Department { DeptID = 101, DeptName = "HR" };
            Club club = new Club { ClubID = 201, ClubName = "Company Club" };
            // Add employees to department
            dept.AddStaff(emp1);
            dept.AddStaff(emp2);
            dept.AddStaff(salesPerson);
            dept.AddStaff(boardMember);

            // Add employees to club
            club.AddMember(emp1);
            club.AddMember(emp2);
            club.AddMember(salesPerson);
            club.AddMember(boardMember);
           
            emp1.EndOfYearOperation();
            emp2.EndOfYearOperation();
            salesPerson.CheckTarget(60); // Assuming the target quota is 60
            boardMember.Resign();



        }
    }
}
