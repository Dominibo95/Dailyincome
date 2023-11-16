using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
