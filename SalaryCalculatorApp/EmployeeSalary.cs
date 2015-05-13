using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class EmployeeSalary
    {
        public string employeeName ;
        public double basicSalary;
        public double houseRentPercentage;
        public double medicalAllowancePercentage;


        public double GetSalary()
        {
            return basicSalary + (houseRentPercentage*basicSalary/100) + (medicalAllowancePercentage*basicSalary/100);
        }
    }
}
