using System.Collections.Generic;
using System.Linq;

namespace Tech.NumberValidator.CountryCodes;

class CountryCallingCodeResult
{
    public CountryCallingCodeResult(int countryCode, string isoCountryCode)
    {
        CountryCallingCode = countryCode;
        CountryIsoCodes = [isoCountryCode];
        RequiredNumberOfDigits = Enumerable.Range(3, 12).ToList();
        Valid = true;
    }

    public CountryCallingCodeResult()
    {
        Valid = false;
        CountryIsoCodes = new List<string>();
        RequiredNumberOfDigits = Enumerable.Range(3, 12).ToList();
    }

    public CountryCallingCodeResult(int countryCallingCode, List<string> isoCountryCodes, params int[] requiredNumberOfDigits)
    {
        CountryCallingCode = countryCallingCode;
        CountryIsoCodes = isoCountryCodes;
        RequiredNumberOfDigits = requiredNumberOfDigits.ToList();
        if (RequiredNumberOfDigits.Count == 0)
        {
            RequiredNumberOfDigits = Enumerable.Range(3, 12).ToList();
        }
        Valid = true;
    }

    public CountryCallingCodeResult(int countryCallingCode, string isoCountryCode, 
        string state, params int[] requiredNumberOfDigits)
    {
        CountryCallingCode = countryCallingCode;
        CountryIsoCodes = [isoCountryCode];
        RequiredNumberOfDigits = requiredNumberOfDigits.ToList();
        State = state;
        Nanp = true;
        Valid = true;
    }

    public CountryCallingCodeResult(int countryCallingCode, string isoCountryCode, 
        bool nanp, params int[] requiredNumberOfDigits)
    {
        CountryCallingCode = countryCallingCode;
        CountryIsoCodes = [isoCountryCode];
        RequiredNumberOfDigits = requiredNumberOfDigits.ToList();
        Nanp = nanp;
        Valid = true;
    }

    public List<string> CountryIsoCodes { get; }
    public int CountryCallingCode { get; }
    public bool Valid { get; }
    public List<int> RequiredNumberOfDigits { get; }
    public string State { get; }

    // North American Numbering Plan (NANP) countries 
    public bool Nanp { get; }

    public bool Validate(string nationalPhoneNumber)
    {
        if (RequiredNumberOfDigits.Contains(nationalPhoneNumber.Length))
        {
            return true;
        }

        return false;
    }
}