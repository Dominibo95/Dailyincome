
namespace DailyIncome
{
    public abstract class JobBase : Job, IJob
    {
        public override string CityName { get; set; }

        public JobBase(string cityName) : base(cityName)
        {
        }

        public abstract void AddWage(double Wage);


        public void AddTip(double Wage)
        {
            throw new NotImplementedException();
        }

        public void AddWage(string Wage)
        {
            throw new NotImplementedException();
        }

        public abstract Statistics GetStatistics();

        public abstract void ShowWages();

        public abstract void ShowStatistics();
    }
}
