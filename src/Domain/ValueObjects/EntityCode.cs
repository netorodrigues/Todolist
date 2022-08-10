using Domain.Exceptions;

namespace Domain.ValueObjects
{
    public sealed record EntityCode
    {
        public string Code { get; private set; }

        public EntityCode()
        {
            Code = Guid.NewGuid().ToString();
        }

        public EntityCode(string entity, string code)
        {
            bool isValid = Guid.TryParse(code, out var entityCode);

            if (!isValid)
            {
                throw new InvalidCodeException(entity, code);
            }

            Code = code;
        }
    }
}
