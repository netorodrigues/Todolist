namespace Domain.Exceptions
{
    public sealed class InvalidColorException : DomainException
    {
        public InvalidColorException(string entity, string colorValue) : base($"'{colorValue}' was an invalid value of color to {entity}") { }
    }
}