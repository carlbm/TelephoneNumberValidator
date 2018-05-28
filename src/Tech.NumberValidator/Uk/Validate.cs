using System.Collections.Generic;

namespace Tech.NumberValidator.Uk
{
    public static class Validate
    {
        private static readonly IList<IValidator> UkNumberValidators = new List<IValidator>
        {
            new UkCountryCodeValidator(),
            new UkStdValidator(),
            new UkSnValidator(),
        };

        public static TelephoneNumber Number(string input)
        {
            var currentNumber = new TelephoneNumber(input);

            foreach (var ukNumberValidator in UkNumberValidators)
            {
                currentNumber = ukNumberValidator.Validate(currentNumber);
            }
            return currentNumber;
        }
    }
}
