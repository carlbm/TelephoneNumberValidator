using System;
using System.Linq;
using Tech.NumberValidator.CountryCodes.StartingWith1;
using Tech.NumberValidator.CountryCodes.StartingWith3;
using Tech.NumberValidator.CountryCodes.StartingWith4;

namespace Tech.NumberValidator.CountryCodes
{
    static class CountryCode
    {
        public static CountryCallingCodeResult Validate(string input)
        {
            if (input.StartsWith("0"))
            {
                throw new ArgumentException("Country Calling Code cannot start with a 0");
            }
            if (input.Length > 4)
            {
                throw new ArgumentException("Country Calling Code maximum length is 4");
            }

            switch (input.First())
            {
                case '1':
                    return CountryCodeStarting1.Validate(input.Substring(1));
                case '2':
                    return CountryCodeStarting1.Validate(input.Substring(1));
                case '3':
                    return CountryCodeStarting3.Validate(input.Substring(1));
                case '4':
                    return CountryCodeStarting4.Validate(input.Substring(1));
                case '5':
                    return CountryCodeStarting1.Validate(input.Substring(1));
                case '6':
                    return CountryCodeStarting1.Validate(input.Substring(1));
                case '7':
                    return CountryCodeStarting1.Validate(input.Substring(1));
                case '8':
                    return CountryCodeStarting1.Validate(input.Substring(1));
                case '9':
                    return CountryCodeStarting1.Validate(input.Substring(1));
            }

            return new CountryCallingCodeResult();
        }
    }
}
