using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith2
{
    static class CountryCodeStarting22
    {
        public static CountryCallingCodeResult Validate(string code)
        {
            switch (code.FirstOrDefault())
            {
                case '0':
                    return new CountryCallingCodeResult(220, "GM");
                case '1':
                    return new CountryCallingCodeResult(221, "SN");
                case '2':
                    return new CountryCallingCodeResult(222, "MR");
                case '3':
                    return new CountryCallingCodeResult(223, "ML");
                case '4':
                    return new CountryCallingCodeResult(224, "GN");
                case '5':
                    return new CountryCallingCodeResult(225, "CI");
                case '6':
                    return new CountryCallingCodeResult(226, "BF");
                case '7':
                    return new CountryCallingCodeResult(227, "NE");
                case '8':
                    return new CountryCallingCodeResult(228, "TG");
                case '9':
                    return new CountryCallingCodeResult(229, "BJ");
            }
            return new CountryCallingCodeResult();
        }
    }
}
