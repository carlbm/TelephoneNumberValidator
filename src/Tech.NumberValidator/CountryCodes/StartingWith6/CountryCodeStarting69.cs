using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith6
{
    static class CountryCodeStarting69
    {
        public static CountryCallingCodeResult Validate(string code)
        {
            switch (code.FirstOrDefault())
            {
                case '0':
                    return new CountryCallingCodeResult(690, "TK");
                case '1':
                    return new CountryCallingCodeResult(691, "FM");
                case '2':
                    return new CountryCallingCodeResult(692, "MH");
            }
            return new CountryCallingCodeResult();
        }
    }
}
