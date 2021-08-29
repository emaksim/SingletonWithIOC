using System.Collections.Generic;

namespace Singleton
{
    public class DummyDatabase : IDatabase
    {
        public int GetPopulation(string city)
        {
            return new Dictionary<string, int>
            {
                ["alfa"] = 1,
                ["beta"] = 2,
                ["gamma"] = 3
            }[city];
        }
    }
}