using System.Collections.Generic;

namespace Tech.NumberValidator.CountryCodes
{
    class CountryCallingCodeResult
    {
        public CountryCallingCodeResult(int countryCode, params string[] isoCountryCodes)
        {
            CountryCallingCode = countryCode;
            CountryIsoCodes = new List<string>(isoCountryCodes);
            Valid = true;
        }

        public CountryCallingCodeResult()
        {
            Valid = false;
            CountryIsoCodes = new List<string>();
        }

        public List<string> CountryIsoCodes { get; set; }
        public int CountryCallingCode { get; set; }
        public bool Valid { get; set; }        
    }
}
