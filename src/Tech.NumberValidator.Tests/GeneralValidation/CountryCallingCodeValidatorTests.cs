using FluentAssertions;
using Tech.NumberValidator.CountryCodes;
using Xunit;

namespace Tech.NumberValidator.Tests.GeneralValidation
{
    public class CountryCallingCodeValidatorTests
    {
        [Theory]
        [InlineData("0447897123654", 44)]
        [InlineData("447897123654", 44)]
        [InlineData("+447897123654", 44)]
        [InlineData("00447897123654", 44)]
        [InlineData("00441926444555", 44)]
        [InlineData("003537897123654", 353)]
        [InlineData("+3537897123654", 353)]
        [InlineData("03537897123654", 353)]
        [InlineData("351(0)7897123654", 351)]
        [InlineData("+3517897123654", 351)]
        [InlineData("03517897123654", 351)]
        [InlineData("003517897123654", 351)]
        
        [InlineData("441234365569", 44)]
        [InlineData("0+447897123654", 44)]
        [InlineData("00+447897123654", 44)]

        [InlineData("020245674567", 20)]

        public void ShouldRecogniseCountryCode(string testNumber, int expectedCountryCallingCode)
        {
            var number = new TelephoneNumber(testNumber);
            var result = CountryCallingCodeValidator.Validate(number);

            result.CountryCallingCode.Should().Be(expectedCountryCallingCode);
        }

        [Theory]
        [InlineData("0447897123654", "7897123654")]
        [InlineData("447897123654", "7897123654")]
        [InlineData("+447897123654", "7897123654")]
        [InlineData("00447897123654", "7897123654")]
        [InlineData("00441926444555", "1926444555")]
        [InlineData("003537897123654", "7897123654")]
        [InlineData("+3537897123654", "7897123654")]
        [InlineData("03537897123654", "7897123654")]
        [InlineData("351(0)7897123654", "7897123654")]
        [InlineData("+3517897123654", "7897123654")]
        [InlineData("03517897123654", "7897123654")]
        [InlineData("003517897123654", "7897123654")]

        [InlineData("441234365569", "1234365569")]
        [InlineData("0+447897123654", "7897123654")]
        [InlineData("00+447897123654", "7897123654")]
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
        [InlineData("968842703")]
        [InlineData("971337851")]
        [InlineData("968495110")]
        [InlineData("973505330")]
        [InlineData("964008242")]
        [InlineData("972860084")]
        [InlineData("375506834")]
        [InlineData("376232868")]
        [InlineData("421215605")]
        [InlineData("977002245")]
        public void ShouldNotRecogniseCountryCallingCodeWhenItDoesNotExist(string testNumber)
        {
            var number = new TelephoneNumber(testNumber);
            var result = CountryCallingCodeValidator.Validate(number);

            result.CountryCallingCodePresent.Should().BeFalse();
        }
    }
}
