using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith3;

static class CountryCodeStarting37
{
    public static CountryCallingCodeResult Validate(string code)
    {
        switch (code.FirstOrDefault())
        {
            case '0':
                return new CountryCallingCodeResult(370, "LT");
            case '1':
                return new CountryCallingCodeResult(371, "LV");
            case '2':
                return new CountryCallingCodeResult(372, "EE");
            case '3':
                return new CountryCallingCodeResult(373, "MD");
            case '4':
                return new CountryCallingCodeResult(374, "AM", "QN");
            case '5':
                return new CountryCallingCodeResult(375, "BY");
            case '6':
                return new CountryCallingCodeResult(376, "AD");
            case '7':
                return new CountryCallingCodeResult(377, "MC");
            case '8':
                return new CountryCallingCodeResult(378, "SM");
            case '9':
                return new CountryCallingCodeResult(379, "VA");
        }
        return new CountryCallingCodeResult();
    }
}