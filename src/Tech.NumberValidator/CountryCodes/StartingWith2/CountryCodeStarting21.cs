using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith2;

static class CountryCodeStarting21
{
    public static CountryCallingCodeResult Validate(string code)
    {
        switch (code.FirstOrDefault())
        {
            case '1':
                return new CountryCallingCodeResult(211, "SS");
            case '2':
                return new CountryCallingCodeResult(212, "MA", "EH");
            case '3':
                return new CountryCallingCodeResult(213, "DZ");
            case '6':
                return new CountryCallingCodeResult(216, "TN");
            case '8':
                return new CountryCallingCodeResult(218, "LY");
        }
        return new CountryCallingCodeResult();
    }
}