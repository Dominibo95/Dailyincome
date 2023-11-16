using System.Diagnostics;

namespace DailyIncome
{
    public class Statistics
    {

        //Job with lowest Wage
        public double MinWagePerDay { get; private set; }

        // job with highest wage 
        public double MaxWagePerDay { get; private set; }

        public double Sum { get; private set; }

        public double AverageDailyPerHour
        {
            get
            {
                return this.Sum / 8;
            }
        }

        public Statistics()
        {
            this.Sum = 0;
            this.MaxWagePerDay = double.MinValue;
            this.MinWagePerDay = double.MaxValue;
        }

        public void AddWage(double wage)
        {
            this.Sum += wage;
            this.MinWagePerDay = Math.Min(wage, this.MinWagePerDay);
            this.MaxWagePerDay = Math.Max(wage, this.MaxWagePerDay);
        }
    }
}
