using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith5;

static class CountryCodeStarting5
{
    public static CountryCallingCodeResult Validate(string localNumber)
    {
        switch (localNumber.First())
        {
            case '0':
                return CountryCodeStarting50.Validate(localNumber.Substring(1));
            case '1':
                return new CountryCallingCodeResult(51, "PE");
            case '2':
                return new CountryCallingCodeResult(52, "MX");
            case '3':
                return new CountryCallingCodeResult(53, "CU");
            case '4':
                return new CountryCallingCodeResult(54, "AR");
            case '5':
                return new CountryCallingCodeResult(55, "BR");
            case '6':
                return new CountryCallingCodeResult(56, "CL");
            case '7':
                return new CountryCallingCodeResult(57, "CO");
            case '8':
                return new CountryCallingCodeResult(58, "VE");
            case '9':
                return CountryCodeStarting59.Validate(localNumber.Substring(1));
        }

        return new CountryCallingCodeResult();
    }
}