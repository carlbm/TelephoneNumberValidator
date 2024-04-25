
namespace Tech.NumberValidator.NumberCleaners;

/// <summary>
/// Ignores any characters before the + 
/// </summary>
class DetectMismatchedPlus : INumberCleaner
{
    public string TestAndClean(string number)
    {
        if (number.IndexOf('+') > 0)
        {
            var cleanedNumber = number.Substring(number.IndexOf('+'));
            return cleanedNumber;
        }

        return number;
    }
}