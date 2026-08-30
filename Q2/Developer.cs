using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    public class Developer : Employee
    {
        public const decimal OvertimeMultiplier = 1.5m;//number is decimal
        public Developer(string name, decimal salary,int overtimeHours): base(name,salary,overtimeHours)// base for shared fields- parent class constructor
        { 
        }
        public override decimal CalculateBonus()// calling helper
        {
            return CalculateOvertimeBonus();
        }
        private decimal CalculateOvertimeBonus()// calculate bonus for developer only-private helper
        {
            return OvertimeHours * CalculateHourlyRate() * OvertimeMultiplier;
        }
    }
}
