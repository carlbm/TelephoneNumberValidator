using System;
using System.Text.RegularExpressions;

namespace Tech.NumberValidator.CountryCodes;

static class CountryCallingCodeValidator 
{
    private static readonly Regex CountryCodeRecogniser = new Regex(@"^(0|00|0{0,2}\+|)([1-9]\d{1,3})(\d{9,10}|\d{7}|\d{3,4})$", RegexOptions.Compiled);

    public static TelephoneNumber Validate(TelephoneNumber input)
    {
        var match = CountryCodeRecogniser.Match(input.CleanedNumber);
        if (match.Success)
        {
            var countryCodeResult = CountryCode.Validate(match.Groups[2].Value);
            if (countryCodeResult.Valid)
            {
                var index = input.CleanedNumber.IndexOf(countryCodeResult.CountryCallingCode.ToString(), StringComparison.OrdinalIgnoreCase) +
                            countryCodeResult.CountryCallingCode.ToString().Length;
                        
                input.NationalPhoneNumber = input.CleanedNumber.Substring(index);

                if (countryCodeResult.Validate(input.NationalPhoneNumber))
                {
                    input.ValidNumber = true;

                    input.CountryCallingCode = countryCodeResult.CountryCallingCode;
                    input.CountryCallingCodePresent = true;
                }
            }
        }

        return input;
    }
}