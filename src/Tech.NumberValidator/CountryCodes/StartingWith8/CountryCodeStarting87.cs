using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith8;

static class CountryCodeStarting87
{
    public static CountryCallingCodeResult Validate(string code)
    {
        switch (code.FirstOrDefault())
        {
            case '0':
                return new CountryCallingCodeResult(870, "XN");
            case '8':
                return new CountryCallingCodeResult(878, "XP");
        }
        return new CountryCallingCodeResult();
    }
}