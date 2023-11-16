using System.Diagnostics;

namespace DailyIncome
{
    public class Statistics
    {

        //Job with lowest Wage
        public double MinWagePerJob { get; private set; }

        // job with highest wage 
        public double MaxWagePerJob { get; private set; }

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
            this.MaxWagePerJob = double.MinValue;
            this.MinWagePerJob = double.MaxValue;
        }

        public void AddJob(double job)
        {
            this.Sum += job;
            this.MinWagePerJob = Math.Min(job, this.MinWagePerJob);
            this.MaxWagePerJob = Math.Max(job, this.MaxWagePerJob);
        }
    }
}
