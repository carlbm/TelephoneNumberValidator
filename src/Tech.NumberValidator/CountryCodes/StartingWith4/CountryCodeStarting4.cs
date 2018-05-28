using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith4
{
    static class CountryCodeStarting4
    {
        public static CountryCallingCodeResult Validate(string localNumber)
        {
            switch (localNumber.First())
            {
                case '0':
                    return new CountryCallingCodeResult(40, "RO");
                case '1':
                    return new CountryCallingCodeResult(41, "CH");
                case '2':
                    return CountryCodeStarting42.Validate(localNumber.Substring(1));
                case '3':
                    return new CountryCallingCodeResult(43, "AT");
                case '4':
                    return new CountryCallingCodeResult(44, "UK", "GB", "GG", "IM", "JE");
                case '5':
                    return new CountryCallingCodeResult(45, "DK");
                case '6':
                    return new CountryCallingCodeResult(46, "SE");
                case '7':
                    return new CountryCallingCodeResult(47, "NO", "SJ", "BV");
                case '8':
                    return new CountryCallingCodeResult(48, "PL");
                case '9':
                    return new CountryCallingCodeResult(49, "DE");
            }

            return new CountryCallingCodeResult();
        }
    }
}
