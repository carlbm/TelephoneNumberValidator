using System.Collections.Generic;

namespace Tech.NumberValidator.Uk;

public static class Validate
{
    private static readonly IList<IValidator> UkNumberValidators = new List<IValidator>
    {
        new UkStdValidator(),
        new UkSnValidator(),
    };

    public static TelephoneNumber Number(TelephoneNumber input)
    {
        var currentNumber = input;
        foreach (var ukNumberValidator in UkNumberValidators)
        {
            currentNumber = ukNumberValidator.Validate(currentNumber);
        }
        return currentNumber;
    }
}