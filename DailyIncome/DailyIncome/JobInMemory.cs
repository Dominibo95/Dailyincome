
using System.Text;

namespace DailyIncome
{
    public class JobInMemory : JobBase
    {
        private List<double> wages;
        public override event WageAddedDelegate WageAdded;

        public JobInMemory(string cityName) : base(cityName)
        {
            wages = new List<double>();
        }

        public override void AddWage(double wage)
        {
            if (wage > 0)
            {
                wages.Add(wage);
                if (WageAdded != null)
                {
                    WageAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid argument: {nameof(wage)}");
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            foreach (var wage in wages)
            {
                result.AddWage(wage);
            }
            return result;
        }

        public override void ShowWages()
        {
            StringBuilder sb = new StringBuilder($" In City {this.CityName} your wages was: ");
            for (int i = 0; i < wages.Count; i++)
            {
                if (i == wages.Count - 1)
                {
                    sb.Append($"{wages[i]}.");
                }
                else
                {
                    sb.Append($"{wages[i]}; ");
                }
            }
            Console.WriteLine($"\n{sb}");
        }
    }
}
