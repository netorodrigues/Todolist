using Domain.Exceptions;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.CustomerAgg.ValueObjects
{
    public sealed class Email
    {
        public string Value { get; private set; }
        public Email(string email) 
        {
            if (!IsValid(email))
                throw new DomainException($"Received an invalid email: {email}");

            Value = email;
        }

        public static bool IsValid(string email) 
        {
            var validator = new EmailAddressAttribute();
            return validator.IsValid(email);
        }
    }
}
