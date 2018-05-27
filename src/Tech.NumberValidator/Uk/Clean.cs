using Tech.NumberValidator.Initialisation;
using Tech.NumberValidator.NumberCleaners;

namespace Tech.NumberValidator.Uk
{
    public static class Clean
    {
        public static string Number(string numberToClean)
        {
            var numberCleaners = NumberCleanerContainer.ResolveAll<INumberCleaner>();
            var currentNumber = new TelephoneNumber(numberToClean);

            foreach (var numberCleaner in numberCleaners)
            {
                currentNumber = numberCleaner.TestAndClean(currentNumber);
            }
            return currentNumber.CleanedNumber;
        }
    }
}
