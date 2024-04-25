
using FluentAssertions;
using Xunit;

namespace Tech.NumberValidator.Tests.GeneralValidation;

public class WhenCallingValidateNumber
{
    [Theory]
    [InlineData("+1-418-543-8090")]
    public void ShouldReturnValidNumber(string testNumber)
    {
        // Act
        var result = Validate.Number(testNumber);

        // Assert
        result.ValidNumber.Should().BeTrue();
    }
}
