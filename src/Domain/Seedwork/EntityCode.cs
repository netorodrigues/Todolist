using Domain.Exceptions;

namespace Domain.Seedwork
{
    public sealed record EntityCode
    {
        public Guid Code { get; private set; }

        public EntityCode()
        {
            Code = Guid.NewGuid();
        }

        public EntityCode(string entity, string code)
        {
            bool isValid = Guid.TryParse(code, out var guidCode);

            if (!isValid)
            {
                throw new InvalidCodeException(entity, code);
            }

            Code = guidCode;
        }
    }
}
