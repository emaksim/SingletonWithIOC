using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Singleton
{
    public class SingletonDatabase : IDatabase
    {
        private Dictionary<string, int> cities;
        public SingletonDatabase()
        {
            cities = File.ReadAllLines(
                    Path.Combine(new FileInfo(typeof(SingletonDatabase).Assembly.Location).DirectoryName, "file.txt"))
                .Batch(2)
                .ToDictionary(list => list.ElementAt(0).Trim(), list => int.Parse(list.ElementAt(1)));
        }

        public int GetPopulation(string city)
        {
            return cities[city];
        }

        private static readonly Lazy<SingletonDatabase> instance =
            new Lazy<SingletonDatabase>(() => new SingletonDatabase());

        public static SingletonDatabase Instance => instance.Value;
    }
}