using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith5;

static class CountryCodeStarting59
{
    public static CountryCallingCodeResult Validate(string code)
    {
        switch (code.FirstOrDefault())
        {
            case '0':
                return new CountryCallingCodeResult(590, "GP", "BL", "MF");
            case '1':
                return new CountryCallingCodeResult(591, "BO");
            case '2':
                return new CountryCallingCodeResult(592, "GY");
            case '3':
                return new CountryCallingCodeResult(593, "EC");
            case '4':
                return new CountryCallingCodeResult(594, "GF");
            case '5':
                return new CountryCallingCodeResult(595, "PY");
            case '6':
                return new CountryCallingCodeResult(596, "MQ");
            case '7':
                return new CountryCallingCodeResult(597, "SR");
            case '8':
                return new CountryCallingCodeResult(598, "UY");
            case '9':
                return new CountryCallingCodeResult(599, "BQ", "CW");
        }
        return new CountryCallingCodeResult();
    }
}