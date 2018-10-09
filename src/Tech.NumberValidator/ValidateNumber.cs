using Tech.NumberValidator.CountryCodes;

namespace Tech.NumberValidator
{
    public static class Validate
    {
        public static TelephoneNumber Number(string input, int defaultCountry = 44)
        {
            var currentNumber = new TelephoneNumber(input);
            var internationalResult = CountryCallingCodeValidator.Validate(currentNumber);
            if (internationalResult.CountryCallingCodePresent)
            {
                // can now work on specific country validation scheme
                return Uk.Validate.Number(internationalResult);
            }
            else
            {
                // Validate the default
                return new TelephoneNumber(input);
            }
        }
    }
}
