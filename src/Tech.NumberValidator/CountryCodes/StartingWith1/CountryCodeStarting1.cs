namespace Tech.NumberValidator.CountryCodes.StartingWith1
{
    static class CountryCodeStarting1
    {
        public static CountryCallingCodeResult Validate(string localNumber)
        {
            if (localNumber.Length == 0)
            {
                return new CountryCallingCodeResult(1, "NANP");
            }

            switch (localNumber)
            {
                case "242":
                    return new CountryCallingCodeResult(1242, "BS");
                case "246":
                    return new CountryCallingCodeResult(1246, "BB");
                case "264":
                    return new CountryCallingCodeResult(1264, "AI");
                case "268":
                    return new CountryCallingCodeResult(1268, "AG");
                case "284":
                    return new CountryCallingCodeResult(1284, "VG");
                case "340":
                    return new CountryCallingCodeResult(1340, "VI");
                case "345":
                    return new CountryCallingCodeResult(1345, "KY");
                case "441":
                    return new CountryCallingCodeResult(1441, "BM");
                case "473":
                    return new CountryCallingCodeResult(1473, "GD");
                case "649":
                    return new CountryCallingCodeResult(1649, "TC");
                case "664":
                    return new CountryCallingCodeResult(1664, "MS");
                case "670":
                    return new CountryCallingCodeResult(1670, "MP");
                case "671":
                    return new CountryCallingCodeResult(1671, "GU");
                case "684":
                    return new CountryCallingCodeResult(1684, "AS");
                case "721":
                    return new CountryCallingCodeResult(1721, "SX");
                case "758":
                    return new CountryCallingCodeResult(1758, "LC");
                case "767":
                    return new CountryCallingCodeResult(1767, "DM");
                case "784":
                    return new CountryCallingCodeResult(1784, "VC");
                case "787":
                    return new CountryCallingCodeResult(1787, "PR");
                case "809":
                    return new CountryCallingCodeResult(1809, "DO");
                case "829":
                    return new CountryCallingCodeResult(1829, "DO");
                case "849":
                    return new CountryCallingCodeResult(1849, "DO");
                case "868":
                    return new CountryCallingCodeResult(1868, "TT");
                case "869":
                    return new CountryCallingCodeResult(1869, "KN");
                case "876":
                    return new CountryCallingCodeResult(1876, "JM");
                case "939":
                    return new CountryCallingCodeResult(1939, "PR");
            }

            return new CountryCallingCodeResult();
        }
    }
}
