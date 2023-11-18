namespace DailyIncome
{
    public class Job
    {
        public virtual string CityName { get; set; }

        public Job(string cityName)
        {
            this.CityName = cityName;
        }
    }
}
