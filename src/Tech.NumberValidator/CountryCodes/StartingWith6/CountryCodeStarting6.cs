using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith6
{
    static class CountryCodeStarting6
    {
        public static CountryCallingCodeResult Validate(string localNumber)
        {
            switch (localNumber.First())
            {
                case '0':
                    return new CountryCallingCodeResult(60, "MY");
                case '1':
                    return new CountryCallingCodeResult(61, "AU", "CX", "CC");
                case '2':
                    return new CountryCallingCodeResult(62, "ID");
                case '3':
                    return new CountryCallingCodeResult(63, "PH");
                case '4':
                    return new CountryCallingCodeResult(64, "NZ", "PN");
                case '5':
                    return new CountryCallingCodeResult(65, "SG");
                case '6':
                    return new CountryCallingCodeResult(66, "TH");
                case '7':
                    return CountryCodeStarting67.Validate(localNumber.Substring(1));
                case '8':
                    return CountryCodeStarting68.Validate(localNumber.Substring(1));
                case '9':
                    return CountryCodeStarting69.Validate(localNumber.Substring(1));
            }

            return new CountryCallingCodeResult();
        }
    }
}
