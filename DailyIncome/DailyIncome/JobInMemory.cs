namespace DailyIncome
{
    public class JobInMemory : JobBase
    {
        private List<double> wages;
        private string cityName;

        public override string CityName
        {
            get
            {
                return $"{char.ToUpper(cityName[0])}{cityName.Substring(1, cityName.Length - 1).ToLower()}";
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    cityName = "Dublin";
                }
            }
        }

        public JobInMemory(string cityName) : base(cityName)
        {
            wages = new List<double>();
        }

        public override void AddWage(double Wage)
        {
            throw new NotImplementedException();
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }

        public override void ShowStatistics()
        {
            throw new NotImplementedException();
        }

        public override void ShowWages()
        {
            throw new NotImplementedException();
        }
    }
}
