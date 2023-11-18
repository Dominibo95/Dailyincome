namespace DailyIncome
{
    public class Statistics
    {

        public double MinWagePerDay { get; private set; }

        public double MaxWagePerDay { get; private set; }

        public double Sum { get; private set; }

        public double AverageDailyPerHour
        {
            get
            {
                return this.Sum / 8;
            }
        }

        public int Count;

        public Statistics()
        {
            Count = 0;
            this.Sum = 0;
            this.MaxWagePerDay = double.MinValue;
            this.MinWagePerDay = double.MaxValue;
        }

        public void AddWage(double wage)
        {
            this.Sum += wage;
            Count += 1;
            this.MinWagePerDay = Math.Min(wage, this.MinWagePerDay);
            this.MaxWagePerDay = Math.Max(wage, this.MaxWagePerDay);
        }
    }
}
