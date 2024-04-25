using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith2;

static class CountryCodeStarting23
{
    public static CountryCallingCodeResult Validate(string code)
    {
        switch (code.FirstOrDefault())
        {
            case '0':
                return new CountryCallingCodeResult(230, "MU");
            case '1':
                return new CountryCallingCodeResult(231, "LR");
            case '2':
                return new CountryCallingCodeResult(232, "SL");
            case '3':
                return new CountryCallingCodeResult(233, "GH");
            case '4':
                return new CountryCallingCodeResult(234, "NG");
            case '5':
                return new CountryCallingCodeResult(235, "TD");
            case '6':
                return new CountryCallingCodeResult(236, "CF");
            case '7':
                return new CountryCallingCodeResult(237, "CM");
            case '8':
                return new CountryCallingCodeResult(238, "CV");
            case '9':
                return new CountryCallingCodeResult(239, "ST");
        }
        return new CountryCallingCodeResult();
    }
}