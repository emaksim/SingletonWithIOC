using Autofac;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<SingletonDatabase>()
                .As<IDatabase>()
                .SingleInstance();
            containerBuilder.RegisterType<SingletonRecordFinder>();
            using var container = containerBuilder.Build();
            var recordFinder = container.Resolve<SingletonRecordFinder>();

            var totalPopulation = recordFinder.TotalPopulation(new[] { "Первый", "Третий" });
        }
    }
}