using System.Linq;

namespace Tech.NumberValidator.CountryCodes.StartingWith6
{
    static class CountryCodeStarting68
    {
        public static CountryCallingCodeResult Validate(string code)
        {
            switch (code.FirstOrDefault())
            {
                case '0':
                    return new CountryCallingCodeResult(680, "PW");
                case '1':
                    return new CountryCallingCodeResult(681, "WF");
                case '2':
                    return new CountryCallingCodeResult(682, "CK");
                case '3':
                    return new CountryCallingCodeResult(683, "NU");
                case '5':
                    return new CountryCallingCodeResult(685, "WS");
                case '6':
                    return new CountryCallingCodeResult(686, "KI");
                case '7':
                    return new CountryCallingCodeResult(687, "NC");
                case '8':
                    return new CountryCallingCodeResult(688, "TV");
                case '9':
                    return new CountryCallingCodeResult(689, "PF");
            }
            return new CountryCallingCodeResult();
        }
    }
}
