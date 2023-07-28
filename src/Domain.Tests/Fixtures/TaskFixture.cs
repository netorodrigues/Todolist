using Bogus;
using DomainTask = Domain.Entities.TaskAgg.Task;

namespace Domain.Tests.Fixtures
{
    public partial class DomainFixture
    {
        public static IEnumerable<DomainTask> GenerateTasks()
        {
            for (int i = 0; i < 10; i++)
                yield return GenerateTask();

            yield break;
        }

        public static DomainTask GenerateTask()
        {
            var faker = new Faker<DomainTask>().CustomInstantiator(x =>
                new DomainTask(x.Lorem.Locale.ToLower(),
                    x.Commerce.ProductMaterial(),
                    x.Random.Guid().ToString(),
                    "Priority"+x.Random.Number(1, 4).ToString(),
                    x.Date.Future()));

            return faker.Generate();
        }
    }
}
