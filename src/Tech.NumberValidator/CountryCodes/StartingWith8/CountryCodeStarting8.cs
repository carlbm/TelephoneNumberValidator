using System.Linq;
using Tech.NumberValidator.CountryCodes.StartingWith6;

namespace Tech.NumberValidator.CountryCodes.StartingWith8;

static class CountryCodeStarting8
{
    public static CountryCallingCodeResult Validate(string localNumber)
    {
        switch (localNumber.First())
        {
            case '0':
                return CountryCodeStarting80.Validate(localNumber.Substring(1));
            case '1':
                return new CountryCallingCodeResult(81, "JP");
            case '2':
                return new CountryCallingCodeResult(82, "KR");
            case '4':
                return new CountryCallingCodeResult(84, "VN");
            case '5':
                return CountryCodeStarting85.Validate(localNumber.Substring(1));
            case '6':
                return new CountryCallingCodeResult(86, "CN");
            case '7':
                return CountryCodeStarting87.Validate(localNumber.Substring(1));
            case '8':
                return CountryCodeStarting88.Validate(localNumber.Substring(1));
        }

        return new CountryCallingCodeResult();
    }
}