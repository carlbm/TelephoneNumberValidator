using System.Collections.Generic;

namespace Tech.NumberValidator.NumberCleaners;

public static class Clean
{
    public static string Number(string numberToClean)
    {
        var numberCleaners = new List<INumberCleaner>
        {
            new DetectMismatchedPlus(),
            new RemoveSpaces(),
            new RemoveZeroAndBrackets(),
            new RemoveNonNumericCharacters(),
        };

        var currentNumber = numberToClean;

        foreach (var numberCleaner in numberCleaners)
        {
            currentNumber = numberCleaner.TestAndClean(currentNumber);
        }
        return currentNumber;
    }
}