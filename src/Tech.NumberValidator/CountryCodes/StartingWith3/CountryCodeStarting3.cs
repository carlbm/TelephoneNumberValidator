using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith3
{
    static class CountryCodeStarting3
    {
        public static CountryCallingCodeResult Validate(string localNumber)
        {
            switch (localNumber.First())
            {
                case '0':
                    return new CountryCallingCodeResult(30, "GR");
                case '1':
                    return new CountryCallingCodeResult(31, "NL");
                case '2':
                    return new CountryCallingCodeResult(32, "BE");
                case '3':
                    return new CountryCallingCodeResult(33, "FR");
                case '4':
                    return new CountryCallingCodeResult(34, "ES");
                case '5':
                    return CountryCodeStarting35.Validate(localNumber.Substring(1));
                case '6':
                    return new CountryCallingCodeResult(36, "HU");
                case '7':
                    return CountryCodeStarting37.Validate(localNumber.Substring(1));
                case '8':
                    return CountryCodeStarting38.Validate(localNumber.Substring(1));
                case '9':
                    return new CountryCallingCodeResult(39, "IT", "VA");
            }

            return new CountryCallingCodeResult();
        }
    }
}
