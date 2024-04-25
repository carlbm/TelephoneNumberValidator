
using System.Linq;

namespace Tech.NumberValidator.NumberCleaners;

public class RemoveNonNumericCharacters : INumberCleaner
{
    public string TestAndClean(string number)
    { 
        return new string(number.Where(c => char.IsDigit(c) || c == '+').ToArray());
    }
}
