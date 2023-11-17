using static DailyIncome.JobBase;

namespace DailyIncome
{
    public interface IJob
    {
        string CityName { get; set; }

        void AddWage(double wage);

        void AddWage(string wage);

        event WageAddedDelegate WageAdded;

        void ShowWages();

        Statistics GetStatistics();

        void ShowStatistics();
    }
}
