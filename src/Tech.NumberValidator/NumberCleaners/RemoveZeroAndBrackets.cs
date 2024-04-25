
using System;

namespace Tech.NumberValidator.NumberCleaners;

public class RemoveZeroAndBrackets : INumberCleaner
{
    public string TestAndClean(string number)
    {
        if (number.IndexOf("(0)", StringComparison.OrdinalIgnoreCase) > 0)
        {
            return number.Replace("(0)", string.Empty);
        }

        return number;
    }
}
