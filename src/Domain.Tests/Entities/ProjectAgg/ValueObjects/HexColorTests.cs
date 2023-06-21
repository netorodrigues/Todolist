using Domain.Exceptions;
using Domain.Seedwork;

namespace Domain.Tests.Entities.ProjectAgg.ValueObjects
{
    public class HexColorTests
    {
        [Fact(DisplayName = @" CASE 01:
            GIVEN a valid hexadecimal string with 6 characters after #
            WHEN trying to generate a HexColor value object from it
            SHOULD create valid HexColor object
        ")]
        public void Valid_HexColor_Object_From_Six_Characters()
        {
            //arrange
            string color = "#C90076";

            //act
            var result = new HexColor(nameof(HexColorTests), color);

            //assert
            Assert.IsType<HexColor>(result);
            Assert.Equal(color, result.Code);

        }

        [Fact(DisplayName = @" CASE 02:
            GIVEN a valid hexadecimal string with 3 characters after #
            WHEN trying to generate a HexColor value object from it
            SHOULD create valid HexColor object
        ")]
        public void Valid_HexColor_Object_From_Three_Characters()
        {
            //arrange
            string color = "#AAA";

            //act
            var result = new HexColor(nameof(HexColorTests), color);

            //assert
            Assert.IsType<HexColor>(result);
            Assert.Equal(color, result.Code);

        }

        [Fact(DisplayName = @" CASE 03:
            GIVEN a invalid guid string
            WHEN trying to generate a HexColor value object from it
            SHOULD throw a InvalidColorException
        ")]
        public void Invalid_HexColor_Object()
        {
            //arrange
            string color = "invalid-color";

            //act
            var result = () => new HexColor(nameof(HexColorTests), color);

            //assert
            Assert.Throws<InvalidColorException>(result);

        }
    }
}