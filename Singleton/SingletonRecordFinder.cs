using System.Collections.Generic;

namespace Singleton
{
    public class SingletonRecordFinder
    {
        private readonly IDatabase database;
        public SingletonRecordFinder(IDatabase database)
        {
            this.database = database;
        }

        public int TotalPopulation(IEnumerable<string> cities)
        {
            var result = 0;
            foreach (var city in cities)
            {
                result += database.GetPopulation(city);
            }

            return result;
        }
    }
}