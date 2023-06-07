using Domain.Entities.CustomerAgg.ValueObjects;
using Domain.Exceptions;
using FluentAssertions;

namespace Domain.Tests.Entities.CustomerAgg.ValueObjects
{
    public class PasswordTests
    {
        [Fact(DisplayName = @"CASE 01: 
                            GIVEN a password creation
                            SHOULD create a password object
                            WHEN receiving a not encrypted password")]
        public void GivenPasswordCreation_ShouldCreateNotEncryptedPasswordObject()
        {
            //arrange
            var passwordString = "some-password";

            //act
            var result = new Password(passwordString);

            //assert
            result.Should().NotBeNull();
            Assert.True(result.Equals(passwordString));

        }

        [Fact(DisplayName = @"CASE 02: 
                            GIVEN a password creation
                            SHOULD create a password object
                            WHEN receiving a encrypted password")]
        public void GivenPasswordCreation_ShouldCreateEncryptedPasswordObject()
        {
            //arrange
            var passwordString = "some-password";
            var passwordEncrypted = new Password(passwordString).Value;

            //act
            var result = new Password(passwordEncrypted);

            //assert
            result.Should().NotBeNull();
            result.Value.Should().Be(passwordEncrypted);
        }

        [Fact(DisplayName = @"CASE 03: 
                            GIVEN a password creation
                            SHOULD throw domain exception
                            WHEN receiving a not encrypted password with invalid length")]
        public void GivenPasswordCreation_ShouldThrowDomainException_WhenReceiveInvalidLengthPassword()
        {
            //arrange
            var passwordString = "some-bigger-password-with-more-than-twenty-characters";

            //act
            var result = () => new Password(passwordString);

            //assert
            result.Should().Throw<DomainException>();
        }

        [Fact(DisplayName = @"CASE 04: 
                            GIVEN a password equals comparsion
                            SHOULD be false
                            WHEN comparing two different passwords")]
        public void GivenPasswordEqualsComparsion_ShouldBeFalse_WhenComparingTwoDifferentPasswords()
        {
            //arrange
            var firstPassword = "some-password";
            var secondPassword = "another-password";

            //act
            var result = new Password(firstPassword);

            //assert
            Assert.True(result.Equals(firstPassword));
            Assert.False(result.Equals(secondPassword));
        }
    }
}
