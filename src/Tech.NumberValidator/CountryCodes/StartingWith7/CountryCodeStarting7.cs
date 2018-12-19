using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith7
{
    static class CountryCodeStarting7
    {
        public static CountryCallingCodeResult Validate(string localNumber)
        {
            switch (localNumber.First())
            {
                case '3':
                    return new CountryCallingCodeResult(73, "RU");
                case '4':
                    return new CountryCallingCodeResult(74, "RU");
                case '6':
                    return new CountryCallingCodeResult(76, "KZ");
                case '7':
                    return new CountryCallingCodeResult(77, "KZ");
                case '8':
                    return new CountryCallingCodeResult(78, "RU");
                case '9':
                    return new CountryCallingCodeResult(79, "RU");
            }

            return new CountryCallingCodeResult();
        }
    }
}
