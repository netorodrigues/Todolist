namespace Domain.Exceptions
{
    public sealed class InvalidCodeException : DomainException
    {
        public InvalidCodeException(string entity, string codeValue) : base($"'{codeValue}' was an invalid value of id for {entity}") { }
    }
}