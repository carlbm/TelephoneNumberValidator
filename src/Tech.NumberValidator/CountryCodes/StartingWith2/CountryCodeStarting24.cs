using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith2;

static class CountryCodeStarting24
{
    public static CountryCallingCodeResult Validate(string code)
    {
        switch (code.FirstOrDefault())
        {
            case '0':
                return new CountryCallingCodeResult(240, "GQ");
            case '1':
                return new CountryCallingCodeResult(241, "GA");
            case '2':
                return new CountryCallingCodeResult(242, "CG");
            case '3':
                return new CountryCallingCodeResult(243, "CD");
            case '4':
                return new CountryCallingCodeResult(244, "AO");
            case '5':
                return new CountryCallingCodeResult(245, "GW");
            case '6':
                return new CountryCallingCodeResult(246, "IO");
            case '7':
                return new CountryCallingCodeResult(247, "AC");
            case '8':
                return new CountryCallingCodeResult(248, "SC");
            case '9':
                return new CountryCallingCodeResult(249, "SD");
        }
        return new CountryCallingCodeResult();
    }
}