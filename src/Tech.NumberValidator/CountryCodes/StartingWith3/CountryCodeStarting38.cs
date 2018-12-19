using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith3
{
    static class CountryCodeStarting38
    {
        public static CountryCallingCodeResult Validate(string code)
        {
            switch (code.FirstOrDefault())
            {
                case '0':
                    return new CountryCallingCodeResult(380, "UA");
                case '1':
                    return new CountryCallingCodeResult(381, "RS");
                case '2':
                    return new CountryCallingCodeResult(382, "ME");
                case '3':
                    return new CountryCallingCodeResult(383, "XK");
                case '5':
                    return new CountryCallingCodeResult(385, "HR");
                case '6':
                    return new CountryCallingCodeResult(386, "SI");
                case '7':
                    return new CountryCallingCodeResult(387, "BA");
                case '8':
                    return new CountryCallingCodeResult(388, "EU");
                case '9':
                    return new CountryCallingCodeResult(389, "MK");
            }
            return new CountryCallingCodeResult();
        }
    }
}
