using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith2;

static class CountryCodeStarting26
{
    public static CountryCallingCodeResult Validate(string code)
    {
        switch (code.FirstOrDefault())
        {
            case '0':
                return new CountryCallingCodeResult(260, "ZM");
            case '1':
                return new CountryCallingCodeResult(261, "MG");
            case '2':
                return new CountryCallingCodeResult(262, "RE", "YT", "TF");
            case '3':
                return new CountryCallingCodeResult(263, "ZW");
            case '4':
                return new CountryCallingCodeResult(264, "NA");
            case '5':
                return new CountryCallingCodeResult(265, "MW");
            case '6':
                return new CountryCallingCodeResult(266, "LS");
            case '7':
                return new CountryCallingCodeResult(267, "BW");
            case '8':
                return new CountryCallingCodeResult(268, "SZ");
            case '9':
                return new CountryCallingCodeResult(269, "KM");
        }
        return new CountryCallingCodeResult();
    }
}