using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith3;

static class CountryCodeStarting35
{
    public static CountryCallingCodeResult Validate(string code)
    {
        switch (code.FirstOrDefault())
        {
            case '0':
                return new CountryCallingCodeResult(350, "GI");
            case '1':
                return new CountryCallingCodeResult(351, "PT");
            case '2':
                return new CountryCallingCodeResult(352, "LU");
            case '3':
                return new CountryCallingCodeResult(353, "IE");
            case '4':
                return new CountryCallingCodeResult(354, "IS");
            case '5':
                return new CountryCallingCodeResult(355, "AL");
            case '6':
                return new CountryCallingCodeResult(356, "MT");
            case '7':
                return new CountryCallingCodeResult(357, "CY");
            case '8':
                return new CountryCallingCodeResult(358, "FI", "AX");
            case '9':
                return new CountryCallingCodeResult(359, "BG");
        }
        return new CountryCallingCodeResult();
    }
}