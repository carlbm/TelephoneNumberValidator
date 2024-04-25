using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith9;

static class CountryCodeStarting97
{
    public static CountryCallingCodeResult Validate(string code)
    {
        switch (code.FirstOrDefault())
        {
            case '0':
                return new CountryCallingCodeResult(970, "PS");
            case '1':
                return new CountryCallingCodeResult(971, "AE");
            case '2':
                return new CountryCallingCodeResult(972, "IL");
            case '3':
                return new CountryCallingCodeResult(973, "BH");
            case '4':
                return new CountryCallingCodeResult(974, "QA");
            case '5':
                return new CountryCallingCodeResult(975, "BT");
            case '6':
                return new CountryCallingCodeResult(976, "MN");
            case '7':
                return new CountryCallingCodeResult(977, "NP");
            case '9':
                return new CountryCallingCodeResult(979, "XR");
        }

        return new CountryCallingCodeResult();
    }
}