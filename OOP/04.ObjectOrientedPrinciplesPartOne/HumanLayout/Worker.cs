using System;
using System.Linq;

namespace HumanLayout
{
    class Worker:Human
    {
        public int WeekSalary { get; set; }
        public byte WorkHoursPerDay { get; set; }

        public Worker(string firstName, string lastName, int weekSalary, byte workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5); // 5 working days at week 
        }
    }
}
