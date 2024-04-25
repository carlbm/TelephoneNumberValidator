using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith6;

static class CountryCodeStarting67
{
    public static CountryCallingCodeResult Validate(string code)
    {
        switch (code.FirstOrDefault())
        {
            case '0':
                return new CountryCallingCodeResult(670, "TL");
            case '2':
                return new CountryCallingCodeResult(672, "NF", "AQ", "HM");
            case '3':
                return new CountryCallingCodeResult(673, "BN");
            case '4':
                return new CountryCallingCodeResult(674, "NR");
            case '5':
                return new CountryCallingCodeResult(675, "PG");
            case '6':
                return new CountryCallingCodeResult(676, "TO");
            case '7':
                return new CountryCallingCodeResult(677, "SB");
            case '8':
                return new CountryCallingCodeResult(678, "VU");
            case '9':
                return new CountryCallingCodeResult(679, "FJ");
        }
        return new CountryCallingCodeResult();
    }
}