using System.Linq;
using Tech.NumberValidator.CountryCodes.StartingWith3;

namespace Tech.NumberValidator.CountryCodes.StartingWith2;

class CountryCodeStarting2
{
    public static CountryCallingCodeResult Validate(string localNumber)
    {
        switch (localNumber.First())
        {
            case '0':
                return new CountryCallingCodeResult(20, "EG", false, 9); // 8 digit EG numbers conflict with UK 020 numbers
            case '1':
                return CountryCodeStarting21.Validate(localNumber.Substring(1));
            case '2':
                return CountryCodeStarting22.Validate(localNumber.Substring(1));
            case '3':
                return CountryCodeStarting23.Validate(localNumber.Substring(1));
            case '4':
                return CountryCodeStarting24.Validate(localNumber.Substring(1));
            case '5':
                return CountryCodeStarting25.Validate(localNumber.Substring(1));
            case '6':
                return CountryCodeStarting26.Validate(localNumber.Substring(1));
            case '7':
                return new CountryCallingCodeResult(27, "ZA");
            case '9':
                return CountryCodeStarting29.Validate(localNumber.Substring(1));
        }

        return new CountryCallingCodeResult();
    }
}