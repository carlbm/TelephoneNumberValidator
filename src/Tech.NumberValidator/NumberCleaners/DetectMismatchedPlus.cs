
namespace Tech.NumberValidator.NumberCleaners
{
    /// <summary>
    /// Ignores any characters before the + 
    /// </summary>
    class DetectMismatchedPlus : INumberCleaner
    {
        public TelephoneNumber TestAndClean(TelephoneNumber number)
        {
            if (number.CleanedNumber.IndexOf('+') > 0)
            {
                var newNumber = new TelephoneNumber(number);
                newNumber.CleanedNumber = number.CleanedNumber.Substring(number.CleanedNumber.IndexOf('+'));
                return newNumber;
            }

            return number;
        }
    }
}
