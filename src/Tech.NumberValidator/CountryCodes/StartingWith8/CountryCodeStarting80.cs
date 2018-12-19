using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith8
{
    static class CountryCodeStarting80
    {
        public static CountryCallingCodeResult Validate(string code)
        {
            switch (code.FirstOrDefault())
            {
                case '0':
                    return new CountryCallingCodeResult(800, "XT");
                case '8':
                    return new CountryCallingCodeResult(808, "XS");
            }
            return new CountryCallingCodeResult();
        }
    }
}
