using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith2;

static class CountryCodeStarting29
{
    public static CountryCallingCodeResult Validate(string code)
    {
        switch (code.FirstOrDefault())
        {
            case '0':
                return new CountryCallingCodeResult(290, "SH", "TA");
            case '1':
                return new CountryCallingCodeResult(291, "ER");
            case '7':
                return new CountryCallingCodeResult(297, "AW");
            case '8':
                return new CountryCallingCodeResult(298, "FO");
            case '9':
                return new CountryCallingCodeResult(299, "GL");
        }
        return new CountryCallingCodeResult();
    }
}