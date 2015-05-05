using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProfile
{
    // Extend Employee class from LINQ to SQL Classes.
    public partial class Employee
    {
        public string FullInfo
        {
            get
            {
                return LastName + ", " + FirstName + " - " + ((DateTime)DOB).ToShortDateString() + " - " + SSN.Substring(5, 4);
            }
        }
    }
}
