using FluentAssertions;
using Tech.NumberValidator.Uk;
using Xunit;

namespace Tech.NumberValidator.Tests.NumberCleanup
{
    public class ZeroAndPlusMismatch
    {
        [Theory]
        [InlineData("0+447926946745", "447926946745")]
        public void IdentifiesIncorrectlyPlacedPlus(string input, string expected)
        {
            var actual = Clean.Number(input);

            actual.Should().Be(expected);
        }
    }
}
