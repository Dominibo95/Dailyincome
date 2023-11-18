namespace DailyIncome
{
    public abstract class JobBase : Job, IJob
    {
        public delegate void WageAddedDelegate(object sender, EventArgs args);

        public abstract event WageAddedDelegate WageAdded;
        public override string CityName { get; set; }

        public JobBase(string cityName) : base(cityName)
        {
        }

        public abstract void AddWage(double wage);

        public void AddWage(string wage)
        {
            if (double.TryParse(wage, out double value))
            {
                this.AddWage(value);
            }
            else if (char.TryParse(wage, out char wageIsChar))
            {
                this.AddWage(wageIsChar);
            }
            else
            {
                throw new Exception("String is not double or char or float");
            }
        }

        public abstract Statistics GetStatistics();

        public abstract void ShowWages();

        public void ShowStatistics()
        {
            var stat = GetStatistics();
            if (stat.Count != 0)
            {
                ShowWages();
                Console.WriteLine($"{CityName}  wages:");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"Total wages: {stat.Count}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Highest grade: {stat.MaxWagePerDay}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Lowest grade: {stat.MinWagePerDay}");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"You today get: {stat.AverageDailyPerHour} per h today");
                Console.WriteLine();
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Couldn't get statistics for {this.CityName} because no wage has been added.");
                Console.ResetColor();
            }
        }

    }
}
