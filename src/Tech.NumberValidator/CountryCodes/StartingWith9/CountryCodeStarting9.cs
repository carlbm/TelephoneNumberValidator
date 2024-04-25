using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith9;

static class CountryCodeStarting9
{
    public static CountryCallingCodeResult Validate(string localNumber)
    {
        switch (localNumber.FirstOrDefault())
        {
            case '0':
                return new CountryCallingCodeResult(90, "TR", "CT");
            case '1':
                return new CountryCallingCodeResult(91, "IN");
            case '2':
                return new CountryCallingCodeResult(92, "PK");
            case '3':
                return new CountryCallingCodeResult(93, "AF");
            case '4':
                return new CountryCallingCodeResult(94, "LK");
            case '5':
                return new CountryCallingCodeResult(95, "MM");
            case '6':
                return CountryCodeStarting96.Validate(localNumber.Substring(1));
            case '7':
                return CountryCodeStarting97.Validate(localNumber.Substring(1));
            case '8':
                return new CountryCallingCodeResult(98, "IR");
            case '9':
                return CountryCodeStarting99.Validate(localNumber.Substring(1));
        }

        return new CountryCallingCodeResult();
    }
}