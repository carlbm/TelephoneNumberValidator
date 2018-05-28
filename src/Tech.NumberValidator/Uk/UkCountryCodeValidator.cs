using System.Text.RegularExpressions;

namespace Tech.NumberValidator.Uk
{
    class UkCountryCodeValidator : IValidator
    {
        private static readonly Regex CountryCodeRecogniser = new Regex(@"^(0044|0*\+44|044|44)(\d{9,10}|\d{7}|\d{3,4})$", RegexOptions.Compiled);
        public TelephoneNumber Validate(TelephoneNumber input)
        {
            var match = CountryCodeRecogniser.Match(input.CleanedNumber);
            if (match.Success)
            {
                input.CountryCallingCode = 44;
                input.CountryCallingCodePresent = true;
                input.NationalPhoneNumber = match.Groups[2].Value;
            }
            return input;
        }
    }
}
