namespace DailyIncome.Test
{
    public class JobTest
    {
        [Test]
        public void ShouldReturnCorrectSumWhenAddDifferentType()
        {
            var job = new JobInMemory("Dublin");
            //setup
            job.AddWage("200");
            job.AddWage(20);
            job.AddWage("20,0");
            
            //act

            var statistics = job.GetStatistics();

            Assert.That(statistics.Sum, Is.EqualTo(240));

        }
    }
}
