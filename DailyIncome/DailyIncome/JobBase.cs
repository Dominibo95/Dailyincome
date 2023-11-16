using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyIncome
{
    public abstract class JobBase : Job, IJob
    {
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

        public void ShowWages()
        {
            throw new NotImplementedException();
        }
    }
}
