using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith9
{
    static class CountryCodeStarting96
    {
        public static CountryCallingCodeResult Validate(string code)
        {
            switch (code.FirstOrDefault())
            {
                case '0':
                    return new CountryCallingCodeResult(960, "MV");
                case '1':
                    return new CountryCallingCodeResult(961, "LB");
                case '2':
                    return new CountryCallingCodeResult(962, "JO");
                case '3':
                    return new CountryCallingCodeResult(963, "SY");
                case '4':
                    return new CountryCallingCodeResult(964, "IQ");
                case '5':
                    return new CountryCallingCodeResult(965, "KW");
                case '6':
                    return new CountryCallingCodeResult(966, "SA");
                case '7':
                    return new CountryCallingCodeResult(967, "YE");
                case '8':
                    return new CountryCallingCodeResult(968, "OM");
            }
            return new CountryCallingCodeResult();
        }
    }
}
