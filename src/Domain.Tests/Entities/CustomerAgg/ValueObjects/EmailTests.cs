using Domain.Entities.CustomerAgg.ValueObjects;
using Domain.Exceptions;
using FluentAssertions;

namespace Domain.Tests.Entities.CustomerAgg.ValueObjects
{
    public class EmailTests
    {
        [Fact(DisplayName = @"CASE 01:
                              GIVEN a email object creation
                              SHOULD create a valid object")]
        public void GivenCreateEmailObject_ShouldCreateValidObject()
        {
            //arrange
            var email = "some@email.com";

            //act
            var result = new Email(email);
            var isValid = Email.IsValid(email);

            //assert
            result.Value.Should().Be(email);
            isValid.Should().BeTrue();
        }

        [Fact(DisplayName = @"CASE 02:
                              GIVEN a email object creation
                              SHOULD throw domain exception
                              WHEN receives a invalid email")]
        public void GivenCreateEmailObject_ShouldThrowDomainException_WhenReceivesInvalidEmail()
        {
            //arrange
            var email = "some-invalid-email";

            //act
            var result = () => new Email(email);
            var isValid = Email.IsValid(email);

            //assert
            result.Should().Throw<DomainException>();
            isValid.Should().BeFalse();
        }
    }
}
