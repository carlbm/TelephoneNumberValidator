using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith5
{
    static class CountryCodeStarting50
    {
        public static CountryCallingCodeResult Validate(string code)
        {
            switch (code.FirstOrDefault())
            {
                case '0':
                    return new CountryCallingCodeResult(500, "FK", "GS");
                case '1':
                    return new CountryCallingCodeResult(501, "BZ");
                case '2':
                    return new CountryCallingCodeResult(502, "GT");
                case '3':
                    return new CountryCallingCodeResult(503, "SV");
                case '4':
                    return new CountryCallingCodeResult(504, "HN");
                case '5':
                    return new CountryCallingCodeResult(505, "NI");
                case '6':
                    return new CountryCallingCodeResult(506, "CR");
                case '7':
                    return new CountryCallingCodeResult(507, "PA");
                case '8':
                    return new CountryCallingCodeResult(508, "PM");
                case '9':
                    return new CountryCallingCodeResult(509, "HT");
            }
            return new CountryCallingCodeResult();
        }
    }
}
