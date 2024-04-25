
namespace Tech.NumberValidator.CountryCodes.StartingWith1;

static class CountryCodeStarting1
{
    public static CountryCallingCodeResult Validate(string localNumber)
    {
        return Nanp.Validate(localNumber);
    }
}