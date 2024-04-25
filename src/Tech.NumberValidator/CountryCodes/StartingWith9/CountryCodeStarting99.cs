using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith9;

static class CountryCodeStarting99
{
    public static CountryCallingCodeResult Validate(string code)
    {
        switch (code.FirstOrDefault())
        {
            case '1':
                return new CountryCallingCodeResult(991, "XC");
            case '2':
                return new CountryCallingCodeResult(992, "TJ");
            case '3':
                return new CountryCallingCodeResult(993, "TM");
            case '4':
                return new CountryCallingCodeResult(994, "AZ");
            case '5':
                return new CountryCallingCodeResult(995, "GE");
            case '6':
                return new CountryCallingCodeResult(996, "KG");
            case '8':
                return new CountryCallingCodeResult(998, "UZ");
        }
        return new CountryCallingCodeResult();
    }
}