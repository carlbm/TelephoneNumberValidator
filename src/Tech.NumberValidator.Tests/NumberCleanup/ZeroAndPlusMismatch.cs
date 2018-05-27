using FluentAssertions;
using Tech.NumberValidator.NumberCleaners;
using Xunit;

namespace Tech.NumberValidator.Tests.NumberCleanup
{
    public class ZeroAndPlusMismatch
    {
        [Theory]
        [InlineData("0+447926946745", "+447926946745")]
        [InlineData("044+7926946745", "+7926946745")]
        [InlineData("+0447926946745", "+0447926946745")]
        [InlineData("0447926946745", "0447926946745")]
        public void IdentifiesIncorrectlyPlacedPlus(string input, string expected)
        {
            var telephoneNumber = new TelephoneNumber(input);
            var actual = new DetectMismatchedPlus().TestAndClean(telephoneNumber).CleanedNumber;

            actual.Should().Be(expected);
        }
    }
}
