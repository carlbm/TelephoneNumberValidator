using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith7;

static class CountryCodeStarting7
{
    public static CountryCallingCodeResult Validate(string localNumber)
    {
        switch (localNumber.First())
        {
            case '0':
                return new CountryCallingCodeResult(7, "KZ", false, 10);
            case '3':
                return new CountryCallingCodeResult(7, "RU", false, 10);
            case '4':
                return new CountryCallingCodeResult(7, "RU", false, 10);
            case '6':
                return new CountryCallingCodeResult(7, "KZ", false, 10);
            case '7':
                return new CountryCallingCodeResult(7, "KZ", false, 10);
            case '8':
                return new CountryCallingCodeResult(7, "RU", false, 10);
            case '9':
                return new CountryCallingCodeResult(7, "RU", false, 10);
        }

        return new CountryCallingCodeResult();
    }
}