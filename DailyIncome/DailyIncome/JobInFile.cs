using System.Text;

namespace DailyIncome
{
    internal class JobInFile : JobBase
    {

        private string fullFileName;

        public JobInFile(string cityName) : base(cityName)
        {
            fullFileName = String.Format("{0:yyyy-MM-dd}__{1}", DateTime.Now, cityName);
        }

        public override event WageAddedDelegate WageAdded;

        public override void AddWage(double wage)
        {
            if (wage > 0)
            {
                using (var writer = File.AppendText($"{fullFileName}"))
                {
                    writer.WriteLine(wage);
                    if (WageAdded != null)
                    {
                        WageAdded(this, new EventArgs());
                    }
                }

            }

            else
            {
                throw new ArgumentException($"Invalid argument: {nameof(wage)}. Only  wage > 0 is allowed!");
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            if (File.Exists($"{fullFileName}"))
            {
                using (var reader = File.OpenText($"{fullFileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = double.Parse(line);
                        result.AddWage(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return result;
        }

        public override void ShowWages()
        {
            StringBuilder sb = new StringBuilder($" In City {this.CityName} today your wages was: ");

            using (var reader = File.OpenText(($"{fullFileName}")))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    sb.Append($"{line}; ");
                    line = reader.ReadLine();
                }
            }
            Console.WriteLine($"\n{sb}");
        }
    }
}
