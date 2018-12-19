using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith8
{
    static class CountryCodeStarting88
    {
        public static CountryCallingCodeResult Validate(string code)
        {
            switch (code.FirstOrDefault())
            {
                case '0':
                    return new CountryCallingCodeResult(880, "BD");
                case '1':
                    return new CountryCallingCodeResult(881, "XG");
                case '2':
                    return new CountryCallingCodeResult(882, "XV");
                case '3':
                    return new CountryCallingCodeResult(883, "XV");
                case '6':
                    return new CountryCallingCodeResult(886, "TW");
                case '8':
                    return new CountryCallingCodeResult(888, "XD");
            }
            return new CountryCallingCodeResult();
        }
    }
}
