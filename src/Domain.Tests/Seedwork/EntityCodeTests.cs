using Domain.Exceptions;
using Domain.Seedwork;

namespace Domain.Tests.ValueObjects
{
    public class EntityCodeTests
    {
        [Fact(DisplayName =@" CASE 01:
            GIVEN a valid guid string
            WHEN trying to generate a EntityCode value object from it
            SHOULD create valid EntityCode object
        ")]
        public void Valid_EntityCode_Object()
        {
            //arrange
            string guid = Guid.NewGuid().ToString();

            //act
            var result = new EntityCode(nameof(EntityCodeTests), guid);

            //assert
            Assert.IsType<EntityCode>(result);
            Assert.Equal(guid, result.Code.ToString());

        }

        [Fact(DisplayName = @" CASE 02:
            GIVEN a invalid guid string
            WHEN trying to generate a EntityCode value object from it
            SHOULD throw a InvalidCodeException
        ")]
        public void Invalid_EntityCode_Object()
        {
            //arrange
            string guid = "invalid-guid";

            //act
            var result = () => new EntityCode(nameof(EntityCodeTests), guid);

            //assert
            Assert.Throws<InvalidCodeException>(result);

        }
    }
}