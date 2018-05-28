using FluentAssertions;
using Tech.NumberValidator.CountryCodes;
using Tech.NumberValidator.Uk;
using Xunit;

namespace Tech.NumberValidator.Tests.GeneralValidation
{
    public class CountryCallingCode
    {
        [Theory]
        [InlineData("01926444555")]
        [InlineData("1926444555")]
        [InlineData("01926351555")]
        [InlineData("01926352555")]
        [InlineData("1926351555")]
        [InlineData("1926352555")]
        public void IsNotRecognisedWhenItDoesNotExist(string testNumber)
        {
            var result = Validate.Number(testNumber);

            result.CountryCallingCodePresent.Should().BeFalse();
        }

        [Theory]
        [InlineData("1-242-456-1234", "BS")]
        [InlineData("1-246-242-1234", "BB")]
        [InlineData("1-264-242-1234", "AI")]
        [InlineData("1-268-242-1234", "AG")]
        [InlineData("1-284-242-1234", "VG")]
        [InlineData("1-340-242-1234", "VI")]
        [InlineData("1-345-242-1234", "KY")]
        [InlineData("1-441-242-1234", "BM")]
        [InlineData("1-473-242-1234", "GD")]
        [InlineData("1-649-242-1234", "TC")]
        [InlineData("1-664-242-1234", "MS")]
        [InlineData("1-670-242-1234", "MP")]
        [InlineData("1-671-242-1234", "GU")]
        [InlineData("1-684-242-1234", "AS")]
        [InlineData("1-721-242-1234", "SX")]
        [InlineData("1-758-242-1234", "LC")]
        [InlineData("1-767-242-1234", "DM")]
        [InlineData("1-784-242-1234", "VC")]
        [InlineData("1-787-242-1234", "PR")]
        [InlineData("1-809-242-1234", "DO")]
        [InlineData("1-829-242-1234", "DO")]
        [InlineData("1-849-242-1234", "DO")]
        [InlineData("1-868-242-1234", "TT")]
        [InlineData("1-869-242-1234", "KN")]
        [InlineData("1-876-242-1234", "JM")]
        [InlineData("1-939-242-1234", "PR")]
        public void ValidateCountryCodeWorksForNanp(string testNumber, string expectedCountry)
        {
            var number = testNumber.Replace("-", string.Empty);
            number = number.Substring(0, 4);
            var result = CountryCode.Validate(number);

            result.CountryIsoCodes.Should().Contain(expectedCountry);
        }

        [Theory]
        // 3x numbers
        [InlineData("307977119232", 30)]

        [InlineData("317977119232", 31)]

        [InlineData("327977119232", 32)]

        [InlineData("337977119232", 33)]

        [InlineData("347977119232", 34)]

        [InlineData("3507977119232", 350)]
        [InlineData("3517977119232", 351)]
        [InlineData("3527977119232", 352)]
        [InlineData("3537977119232", 353)]
        [InlineData("3547977119232", 354)]
        [InlineData("3557977119232", 355)]
        [InlineData("3567977119232", 356)]
        [InlineData("3577977119232", 357)]
        [InlineData("3587977119232", 358)]
        [InlineData("3597977119232", 359)]

        [InlineData("367977119232", 36)]

        [InlineData("3707977119232", 370)]
        [InlineData("3717977119232", 371)]
        [InlineData("3727977119232", 372)]
        [InlineData("3737977119232", 373)]
        [InlineData("3747977119232", 374)]
        [InlineData("3757977119232", 375)]
        [InlineData("3767977119232", 376)]
        [InlineData("3777977119232", 377)]
        [InlineData("3787977119232", 378)]
        [InlineData("3797977119232", 379)]

        [InlineData("3807977119232", 380)]
        [InlineData("3817977119232", 381)]
        [InlineData("3827977119232", 382)]
        [InlineData("3837977119232", 383)]
        [InlineData("3857977119232", 385)]
        [InlineData("3867977119232", 386)]
        [InlineData("3877977119232", 387)]
        [InlineData("3887977119232", 388)]
        [InlineData("3897977119232", 389)]

        [InlineData("397977119232", 39)]

        // 4x numbers
        [InlineData("407977119232", 40)]
        [InlineData("417977119232", 41)]

        [InlineData("4207977119232", 420)]
        [InlineData("4217977119232", 421)]
        [InlineData("4237977119232", 423)]

        [InlineData("437977119232", 43)]

        [InlineData("447977119232", 44)]

        [InlineData("457977119232", 45)]

        [InlineData("467977119232", 46)]

        [InlineData("477977119232", 47)]

        [InlineData("487977119232", 48)]

        [InlineData("497977119232", 49)]

        public void ValidateCountryCodeWorksForEurope(string testNumber, int expectedCountryCallingCode)
        {
            var number = testNumber.Substring(0, 4);
            var result = CountryCode.Validate(number);

            result.CountryCallingCode.Should().Be(expectedCountryCallingCode);
        }
    }
}
