using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith8
{
    static class CountryCodeStarting85
    {
        public static CountryCallingCodeResult Validate(string code)
        {
            switch (code.FirstOrDefault())
            {
                case '0':
                    return new CountryCallingCodeResult(850, "KP");
                case '2':
                    return new CountryCallingCodeResult(852, "HK");
                case '3':
                    return new CountryCallingCodeResult(853, "MO");
                case '5':
                    return new CountryCallingCodeResult(855, "KH");
                case '6':
                    return new CountryCallingCodeResult(856, "LA");
            }
            return new CountryCallingCodeResult();
        }
    }
}
