namespace DailyIncome
{
    public interface IJob
    {
        int JobId { get; }

        //dodaje obiekt task do obiektu job 
       // void AddTask();





       // event JobAddedDelegate JobAdded;
        Statistics GetStatistics { get; }
    }
}
