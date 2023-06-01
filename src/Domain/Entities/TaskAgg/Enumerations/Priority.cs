using Ardalis.SmartEnum;

namespace Domain.Entities.TaskAgg.Enumerations
{
    public sealed class Priority : SmartEnum<Priority>
    {
        public static readonly Priority Priority1 = new Priority(nameof(Priority1), 1);
        public static readonly Priority Priority2 = new Priority(nameof(Priority2), 1);
        public static readonly Priority Priority3 = new Priority(nameof(Priority3), 1);
        public static readonly Priority Priority4 = new Priority(nameof(Priority4), 1);

        private Priority(string name, int value) : base(name, value)
        {
        }
    }
}
