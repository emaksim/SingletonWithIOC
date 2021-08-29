using NUnit.Framework;
using Singleton;

namespace Sigleton.Tests
{
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void SingletonTotalPopulationTests()
        {
            var dd = new DummyDatabase();
            var rf = new SingletonRecordFinder(dd);
            Assert.That(
                rf.TotalPopulation(new[] { "alfa", "gamma" }),
                Is.EqualTo(4));
        }
    }
}