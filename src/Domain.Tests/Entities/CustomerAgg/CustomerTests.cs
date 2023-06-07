using Domain.Entities.CustomerAgg;
using FluentAssertions;

namespace Domain.Tests.Entities.CustomerAgg
{
    public class CustomerTests
    {
        [Fact(DisplayName = @" CASE 01:
            GIVEN A customer object build
            SHOULD create customer object")]
        public void ShouldCreateCustomer()
        {
            //arrange
            var name = "a-customer-name";
            var password = "some-password";
            var email = "some@email.com";

            //act
            var result = new Customer(name, password, email);

            //assert
            result.Should().NotBeNull();
            result.Id.Should().NotBeNull();
            result.Name.Should().Be(name);
            Assert.True(result.Password.Equals(password));
            result.Email.Value.Should().Be(email);
        }
    }
}
