using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4_adv_c_
{
    public class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }

        public int EmployeeID { get; set; }
        public DateTime BirthDate { get; set; }
        public int VacationStock { get; set; }

        public bool RequestVacation(DateTime from, DateTime to)
        {
           
            throw new NotImplementedException();
        }

        public void EndOfYearOperation()
        {
            if (VacationStock < 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.VacationStockNegative });
            }
            if (DateTime.Now.Year - BirthDate.Year > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.AgeOverSixty });
            }
        }
        public enum LayOffCause
        {
            VacationStockNegative,
            AgeOverSixty,
            FailedSalesTarget,
            Resigned
        }
        public class EmployeeLayOffEventArgs : EventArgs
        {
            public LayOffCause Cause { get; set; }
        }

    }
}
