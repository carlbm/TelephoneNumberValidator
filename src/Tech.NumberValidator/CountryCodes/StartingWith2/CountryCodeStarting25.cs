using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith2;

static class CountryCodeStarting25
{
    public static CountryCallingCodeResult Validate(string code)
    {
        switch (code.FirstOrDefault())
        {
            case '0':
                return new CountryCallingCodeResult(250, "RW");
            case '1':
                return new CountryCallingCodeResult(251, "ET");
            case '2':
                return new CountryCallingCodeResult(252, "SO");
            case '3':
                return new CountryCallingCodeResult(253, "DJ");
            case '4':
                return new CountryCallingCodeResult(254, "KE");
            case '5':
                return new CountryCallingCodeResult(255, "TZ");
            case '6':
                return new CountryCallingCodeResult(256, "UG");
            case '7':
                return new CountryCallingCodeResult(257, "BI");
            case '8':
                return new CountryCallingCodeResult(258, "MZ");
        }
        return new CountryCallingCodeResult();
    }
}