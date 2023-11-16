namespace DailyIncome
{
    public interface IJob
    {
        string CityName { get; set; }

        void AddWage(double Wage);

        void AddWage(string Wage);

        void AddTip(double Wage);

        void ShowWages();

        Statistics GetStatistics();

        void ShowStatistics();
    }
}
