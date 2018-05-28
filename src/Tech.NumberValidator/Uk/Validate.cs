using System.Collections.Generic;
using Tech.NumberValidator.CountryCodes;

namespace Tech.NumberValidator.Uk
{
    public static class Validate
    {
        private static readonly IList<IValidator> UkNumberValidators = new List<IValidator>
        {
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
