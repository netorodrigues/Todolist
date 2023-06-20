using Domain.Exceptions;

namespace Domain.Seedwork
{
    public record EntityCode<T>
    {
        public Guid Code { get; private set; }

        public EntityCode()
        {
            Code = Guid.NewGuid();
        }

        public EntityCode(string code)
        {
            bool isValid = Guid.TryParse(code, out var guidCode);

            if (!isValid)
            {
                throw new InvalidCodeException(nameof(T), code);
            }

            Code = guidCode;
        }
    }
}
