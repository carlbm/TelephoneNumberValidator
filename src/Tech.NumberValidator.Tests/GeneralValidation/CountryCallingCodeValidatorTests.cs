using FluentAssertions;
using Tech.NumberValidator.CountryCodes;
using Xunit;

namespace Tech.NumberValidator.Tests.GeneralValidation
{
    public class CountryCallingCodeValidatorTests
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
        
        [InlineData("441234365569", 44)]
        [InlineData("0+447977119232", 44)]
        [InlineData("00+447977119232", 44)]

        public void ShouldRecogniseCountryCode(string testNumber, int expectedCountryCallingCode)
        {
            var number = new TelephoneNumber(testNumber);
            var result = CountryCallingCodeValidator.Validate(number);

            result.CountryCallingCode.Should().Be(expectedCountryCallingCode);
        }

        [Theory]
        [InlineData("0447977119232", "7977119232")]
        [InlineData("447977119232", "7977119232")]
        [InlineData("+447977119232", "7977119232")]
        [InlineData("00447977119232", "7977119232")]
        [InlineData("00441926444555", "1926444555")]
        [InlineData("003537977119232", "7977119232")]
        [InlineData("+3537977119232", "7977119232")]
        [InlineData("03537977119232", "7977119232")]
        [InlineData("351(0)7977119232", "7977119232")]
        [InlineData("+3517977119232", "7977119232")]
        [InlineData("03517977119232", "7977119232")]
        [InlineData("003517977119232", "7977119232")]

        [InlineData("441234365569", "1234365569")]
        [InlineData("0+447977119232", "7977119232")]
        [InlineData("00+447977119232", "7977119232")]
        public void ShouldCalculateNationalNumber(string testNumber, string expectedNationalNumber)
        {
            var number = new TelephoneNumber(testNumber);
            var result = CountryCallingCodeValidator.Validate(number);

            result.NationalPhoneNumber.Should().Be(expectedNationalNumber);
        }

        [Theory]
        [InlineData("02083379484")]
        [InlineData("07506794552")]
        [InlineData("12135550123")]
        [InlineData("123456789")]
        [InlineData("111111111")]
        [InlineData("1111111111")]
        [InlineData("111")]
        [InlineData("1111")]
        [InlineData("11111")]
        [InlineData("111111")]
        [InlineData("1111111")]
        [InlineData("11111111")]
        [InlineData("11111111111")]
        [InlineData("111111111111")]
        [InlineData("1111111111111")]
        public void ShouldNotRecogniseCountryCallingCodeWhenItDoesNotExist(string testNumber)
        {
            var number = new TelephoneNumber(testNumber);
            var result = CountryCallingCodeValidator.Validate(number);

            result.CountryCallingCodePresent.Should().BeFalse();
        }
    }
}
