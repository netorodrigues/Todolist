using Domain.Entities.CustomerAgg.ValueObjects;
using Domain.Seedwork;

namespace Domain.Entities.CustomerAgg
{
    public class Customer
    {
        public CustomerId Id { get; private set; }
        public string Name { get; private set; }
        public Password Password { get; private set; }
        public Email Email { get; private set; }

        public Customer(string name, string password, string email) 
        {
            Id = new CustomerId();
            Name = name;
            Password = new Password(password);
            Email = new Email(email);
        }

        public Customer(string id, string name, string password, string email)
        {
            Id = new CustomerId(id);
            Name = name;
            Password = new Password(password);
            Email = new Email(email);
        }

    }
}
