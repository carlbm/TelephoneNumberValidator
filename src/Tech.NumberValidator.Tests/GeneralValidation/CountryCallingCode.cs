using FluentAssertions;
using Tech.NumberValidator.CountryCodes;
using Tech.NumberValidator.Uk;
using Xunit;

namespace Tech.NumberValidator.Tests.GeneralValidation
{
    public class CountryCallingCode
    {
        [Theory]
        [InlineData("0447977119232", 44)]
        [InlineData("447977119232", 44)]
        [InlineData("+447977119232", 44)]
        [InlineData("00447977119232", 44)]
        [InlineData("00441926444555", 44)]
        [InlineData("003537977119232", 353)]
        [InlineData("+3537977119232", 353)]
        [InlineData("03537977119232", 353)]
        [InlineData("351(0)7977119232", 351)]
        [InlineData("+3517977119232", 351)]
        [InlineData("03517977119232", 351)]
        [InlineData("003517977119232", 351)]
        public void IsRecognisedWhenItExists(string testNumber, int countryCallingCode)
        {
            var result = Validate.Number(testNumber);

            result.CountryCallingCode.Should().Be(countryCallingCode);
        }

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
            var result = ValidateCountryCode.Validate(number);

            result.CountryIsoCodes.Should().Contain(expectedCountry);
        }

        [Theory]
        [InlineData("447977119232", 44)]
        [InlineData("3517977119232", 351)]
        [InlineData("3537977119232", 353)]
        [InlineData("347977119232", 34)]
        public void ValidateCountryCodeWorksForEurope(string testNumber, int expectedCountryCallingCode)
        {
            var number = testNumber.Substring(0, 4);
            var result = ValidateCountryCode.Validate(number);

            result.CountryCallingCode.Should().Be(expectedCountryCallingCode);
        }
    }
}
