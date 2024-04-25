
namespace Tech.NumberValidator.NumberCleaners;

public class RemoveSpaces : INumberCleaner
{
    public string TestAndClean(string number)
    {
        var cleanedNumber = number.Replace(" ", string.Empty);
        return cleanedNumber;
    }
}
