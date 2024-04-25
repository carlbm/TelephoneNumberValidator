using FluentAssertions;
using Tech.NumberValidator.CountryCodes;
using Xunit;

namespace Tech.NumberValidator.Tests.GeneralValidation;

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
    [InlineData("19392421234", "PR")]
    public void ValidateCountryCodeWorksForNanp(string testNumber, string expectedCountry)
    {
        var number = testNumber.Replace("-", string.Empty);
        number = number.Substring(0, 4);
        var result = CountryCode.Validate(number);

        result.CountryIsoCodes.Should().Contain(expectedCountry);
    }

    [Theory]
    //[InlineData("18009256278", "US")]
    [InlineData("+1-418-543-8090", "CA")]
    public void ValidNumberShowsCorrectCountryForUs(string testNumber, string expectedCountry)
    {
        var number = testNumber.Replace("-", string.Empty);
        var result = CountryCode.Validate(number);

        result.CountryIsoCodes.Should().Contain(expectedCountry);
    }


    [Theory]
    // 3x numbers
    [InlineData("307897123654", 30)]

    [InlineData("317897123654", 31)]

    [InlineData("327897123654", 32)]

    [InlineData("337897123654", 33)]

    [InlineData("347897123654", 34)]

    [InlineData("3507897123654", 350)]
    [InlineData("3517897123654", 351)]
    [InlineData("3527897123654", 352)]
    [InlineData("3537897123654", 353)]
    [InlineData("3547897123654", 354)]
    [InlineData("3557897123654", 355)]
    [InlineData("3567897123654", 356)]
    [InlineData("3577897123654", 357)]
    [InlineData("3587897123654", 358)]
    [InlineData("3597897123654", 359)]

    [InlineData("367897123654", 36)]

    [InlineData("3707897123654", 370)]
    [InlineData("3717897123654", 371)]
    [InlineData("3727897123654", 372)]
    [InlineData("3737897123654", 373)]
    [InlineData("3747897123654", 374)]
    [InlineData("3757897123654", 375)]
    [InlineData("3767897123654", 376)]
    [InlineData("3777897123654", 377)]
    [InlineData("3787897123654", 378)]
    [InlineData("3797897123654", 379)]

    [InlineData("3807897123654", 380)]
    [InlineData("3817897123654", 381)]
    [InlineData("3827897123654", 382)]
    [InlineData("3837897123654", 383)]
    [InlineData("3857897123654", 385)]
    [InlineData("3867897123654", 386)]
    [InlineData("3877897123654", 387)]
    [InlineData("3887897123654", 388)]
    [InlineData("3897897123654", 389)]

    [InlineData("397897123654", 39)]

    // 4x numbers
    [InlineData("407897123654", 40)]
    [InlineData("417897123654", 41)]

    [InlineData("4207897123654", 420)]
    [InlineData("4217897123654", 421)]
    [InlineData("4237897123654", 423)]

    [InlineData("437897123654", 43)]

    [InlineData("447897123654", 44)]

    [InlineData("457897123654", 45)]

    [InlineData("467897123654", 46)]

    [InlineData("477897123654", 47)]

    [InlineData("487897123654", 48)]

    [InlineData("497897123654", 49)]

    public void ValidateCountryCodeWorksForEurope(string testNumber, int expectedCountryCallingCode)
    {
        var result = CountryCode.Validate(testNumber);

        result.CountryCallingCode.Should().Be(expectedCountryCallingCode);
    }

    // 9x numbers
    [Theory]
    [InlineData("902465789", 90)]
    [InlineData("912465789", 91)]
    [InlineData("922465789", 92)]
    [InlineData("932465789", 93)]
    [InlineData("942465789", 94)]
    [InlineData("9502465789", 95)]
    [InlineData("9602465789", 960)]
    [InlineData("9612465789", 961)]
    [InlineData("9622465789", 962)]
    [InlineData("9632465789", 963)]
    [InlineData("9642465789", 964)]
    [InlineData("9652465789", 965)]
    [InlineData("9662465789", 966)]
    [InlineData("9672465789", 967)]
    [InlineData("9682465789", 968)]
    [InlineData("9702465789", 970)]
    [InlineData("9712465789", 971)]
    [InlineData("972465789", 972)]
    [InlineData("9732465789", 973)]
    [InlineData("9742465789", 974)]
    [InlineData("9752465789", 975)]
    [InlineData("9762465789", 976)]
    [InlineData("9772465789", 977)]
    [InlineData("9792465789", 979)]
    [InlineData("982465789", 98)]
    [InlineData("9912465789", 991)]
    [InlineData("9922465789", 992)]
    [InlineData("9932465789", 993)]
    [InlineData("9942465789", 994)]
    [InlineData("9952465789", 995)]
    [InlineData("9962465789", 996)]
    [InlineData("9982465789", 998)]
    public void ValidateCountryCodeWorksForAsia(string testNumber, int expectedCountryCallingCode)
    {
        var number = testNumber.Substring(0, 4);
        var result = CountryCode.Validate(number);

        result.CountryCallingCode.Should().Be(expectedCountryCallingCode);
    }
}