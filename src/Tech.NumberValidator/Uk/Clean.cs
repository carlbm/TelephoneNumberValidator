using System.Collections.Generic;
using Tech.NumberValidator.NumberCleaners;

namespace Tech.NumberValidator.Uk
{
    public static class Clean
    {
        public static string Number(string numberToClean)
        {
            var numberCleaners = new List<INumberCleaner>
            {
                new DetectMismatchedPlus(),
            };

            var currentNumber = new TelephoneNumber(numberToClean);

            foreach (var numberCleaner in numberCleaners)
            {
                currentNumber = numberCleaner.TestAndClean(currentNumber);
            }
            return currentNumber.CleanedNumber;
        }
    }
}
