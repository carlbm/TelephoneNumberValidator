using System;
using System.Linq;
using Tech.NumberValidator.CountryCodes.StartingWith1;
using Tech.NumberValidator.CountryCodes.StartingWith3;
using Tech.NumberValidator.CountryCodes.StartingWith4;
using Tech.NumberValidator.CountryCodes.StartingWith9;

namespace Tech.NumberValidator.CountryCodes
{
    static class CountryCode
    {
        public static CountryCallingCodeResult Validate(string input)
        {
            if (input.Length > 4)
            {
                input = input.Substring(0, 4);
            }

            switch (input.First())
            {
                case '0':
                    throw new ArgumentException("Country Calling Code cannot start with a 0");
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
                    return CountryCodeStarting9.Validate(input.Substring(1));
            }

            return new CountryCallingCodeResult();
        }
    }
}
