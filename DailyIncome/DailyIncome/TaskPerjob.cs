namespace DailyIncome
{
    public class TaskPerjob
    {
        public TaskPerjob()
        {
        }
        public string Name { get; private set; }

        public double Wage { get; private set; }

        public readonly List<KeyValuePair<string, double>> tasks;

        public void AddTask(string Name, double Wage)
        {
            if (Wage > 0)
            {
                tasks.Add(new KeyValuePair<string, double>(Name, Wage)); ;
            }
            else
            {
                throw new ArgumentException($"Invalid argument: Wage need be higher then 0 !");
            }
        }

    }

}

