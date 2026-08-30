using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    public class Manager : Employee
    {
        public const decimal OvertimeMuliplier = 2.0m;
        public Manager(string name, decimal salary, int overtimeHours) : base(name, salary, overtimeHours)
            {
        }
        public override decimal CalculateBonus()//calls helper
        {
            return CalculateOvertimeBonus();
        }
        private decimal CalculateOvertimeBonus() //private helper that calculates the bonus
        {
            return OvertimeHours * CalculateHourlyRate() * OvertimeMuliplier;

        }
    } }
