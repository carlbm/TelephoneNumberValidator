using System.Collections.Generic;
using System.Linq;

namespace Tech.NumberValidator.CountryCodes;

class CountryCallingCodeResult
{
    public CountryCallingCodeResult(int countryCode, params string[] isoCountryCodes)
    {
        CountryCallingCode = countryCode;
        CountryIsoCodes = new List<string>(isoCountryCodes);
        RequiredNumberOfDigits = Enumerable.Range(1, 12).ToList();
        Valid = true;
    }

    public CountryCallingCodeResult()
    {
        Valid = false;
        CountryIsoCodes = new List<string>();
        RequiredNumberOfDigits = Enumerable.Range(1, 12).ToList();
    }

    public CountryCallingCodeResult(int countryCallingCode, string isoCountryCode, 
        string state, params int[] requiredNumberOfDigits)
    {
        CountryCallingCode = countryCallingCode;
        CountryIsoCodes = new List<string> {isoCountryCode};
        RequiredNumberOfDigits = requiredNumberOfDigits.ToList();
        State = state;
        Nanp = true;
        Valid = true;
    }

    public CountryCallingCodeResult(int countryCallingCode, string isoCountryCode, 
        bool nanp, params int[] requiredNumberOfDigits)
    {
        CountryCallingCode = countryCallingCode;
        CountryIsoCodes = new List<string> { isoCountryCode };
        RequiredNumberOfDigits = requiredNumberOfDigits.ToList();
        Nanp = true;
        Valid = true;
    }

    public List<string> CountryIsoCodes { get; }
    public int CountryCallingCode { get; }
    public bool Valid { get; }
    public List<int> RequiredNumberOfDigits { get; } = new List<int>();
    public string State { get; }
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