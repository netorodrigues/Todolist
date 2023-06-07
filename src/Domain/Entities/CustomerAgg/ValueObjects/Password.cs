using Domain.Exceptions;
using static BCrypt.Net.BCrypt;

namespace Domain.Entities.CustomerAgg.ValueObjects
{
    public sealed class Password
    {
        public string Value { get; private set; }

        private const int PasswordWorkFactor = 12;

        private const int HashedPasswordLength = 60;

        private const int MaxPasswordLength = 20;

        public Password(string password) 
        {
            if (password.Length == HashedPasswordLength)
            {
                Value = password;
                return;
            }

            if (password.Length != HashedPasswordLength && password.Length > MaxPasswordLength)
                throw new DomainException($"Received a password with invalid length: {password}");

            Value = HashPassword(password, PasswordWorkFactor);
        }

        public bool Equals(string password)
        {
            return Verify(password, Value);
        }

    }
}
