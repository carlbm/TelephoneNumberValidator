using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith4
{
    static class CountryCodeStarting42
    {
        public static CountryCallingCodeResult Validate(string code)
        {
            switch (code.First())
            {
                case '0':
                    return new CountryCallingCodeResult(420, "CZ");
                case '1':
                    return new CountryCallingCodeResult(421, "SK");
                case '3':
                    return new CountryCallingCodeResult(423, "LI");
            }
            return new CountryCallingCodeResult();
        }
    }
}
