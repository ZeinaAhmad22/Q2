using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    public abstract class Employee //can only be inherited from
    {
        public const int MonthlyHours = 160;//how many hours make up a work month-to convert monthly into hourly salary
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int OvertimeHours {  get; set; }
        public Employee(string name, decimal salary, int overtimeHours)
        {
            this.Name = name;
            this.Salary = salary;
            this.OvertimeHours = overtimeHours;
        }

        public abstract decimal CalculateBonus();
        protected decimal CalculateHourlyRate()// converts monthly salary to hourly rate- dividing by 160
        {
            return Salary / MonthlyHours;
        }
        public override string ToString()
        {
            return $"Name:{Name}" +
            $"\nSalary: ${Math.Round(Salary, 2):N0}" +
            $"\nOvertime Hours: {OvertimeHours}" +
            $"\nBonus: ${Math.Round(CalculateBonus(), 2):N0}";

        }
    }
}


