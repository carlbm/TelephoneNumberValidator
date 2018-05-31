namespace Tech.NumberValidator.CountryCodes.StartingWith1
{
    static class Nanp
    {
        public static CountryCallingCodeResult Validate(string code)
        {
            switch (code)
            {
                // Non-us/ca
                case "242":
                    return new CountryCallingCodeResult(1242, "BS", true, 7);
                case "246":
                    return new CountryCallingCodeResult(1246, "BB", true, 7);
                case "264":
                    return new CountryCallingCodeResult(1264, "AI", true, 7);
                case "268":
                    return new CountryCallingCodeResult(1268, "AG", true, 7);
                case "284":
                    return new CountryCallingCodeResult(1284, "VG", true, 7);

                case "340":
                    return new CountryCallingCodeResult(1340, "VI", false, 7);
                case "345":
                    return new CountryCallingCodeResult(1345, "KY", false, 7);

                case "441":
                    return new CountryCallingCodeResult(1441, "BM", false, 7);
                case "473":
                    return new CountryCallingCodeResult(1473, "GD", false, 7);

                case "649":
                    return new CountryCallingCodeResult(1649, "TC", false, 7);
                case "664":
                    return new CountryCallingCodeResult(1664, "MS", false, 7);
                case "670":
                    return new CountryCallingCodeResult(1670, "MP", false, 7);
                case "671":
                    return new CountryCallingCodeResult(1671, "GU", false, 7);
                case "684":
                    return new CountryCallingCodeResult(1684, "AS", false, 7);

                case "721":
                    return new CountryCallingCodeResult(1721, "SX", false, 7);
                case "758":
                    return new CountryCallingCodeResult(1758, "LC", false, 7);
                case "767":
                    return new CountryCallingCodeResult(1767, "DM", false, 7);
                case "784":
                    return new CountryCallingCodeResult(1784, "VC", false, 7);
                case "787":
                case "939":
                    return new CountryCallingCodeResult(1787, "PR", false, 7);

                case "809":
                case "829":
                case "849":
                    return new CountryCallingCodeResult(1849, "DO", false, 7);
                case "868":
                    return new CountryCallingCodeResult(1868, "TT", false, 7);
                case "869":
                    return new CountryCallingCodeResult(1869, "KN", false, 7);
                case "876":
                    return new CountryCallingCodeResult(1876, "JM", false, 7);
                    


                // Us
                case "205":
                case "251":
                case "256":
                case "334":
                case "938":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "AL", 7);

                case "907":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "AK", 7);

                case "480":
                case "520":
                case "602":
                case "623":
                case "928":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "AZ", 7);

                case "327":
                case "479":
                case "501":
                case "870":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "AR", 7);

                case "209":
                case "213":
                case "279":
                case "310":
                case "323":
                case "408":
                case "415":
                case "424":
                case "442":
                case "510":
                case "530":
                case "559":
                case "562":
                case "619":
                case "626":
                case "628":
                case "650":
                case "657":
                case "661":
                case "669":
                case "707":
                case "714":
                case "747":
                case "760":
                case "805":
                case "818":
                case "820":
                case "831":
                case "858":
                case "909":
                case "916":
                case "925":
                case "949":
                case "951":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "CA", 7);

                case "303":
                case "719":
                case "720":
                case "970":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "CO", 7);

                case "203":
                case "475":
                case "860":
                case "959":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "CT", 7);

                case "302":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "DE", 7);

                case "202":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "DC", 7);

                case "239":
                case "305":
                case "321":
                case "352":
                case "386":
                case "407":
                case "561":
                case "689":
                case "727":
                case "754":
                case "772":
                case "786":
                case "813":
                case "850":
                case "863":
                case "904":
                case "941":
                case "954":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "FL", 7);

                case "229":
                case "404":
                case "470":
                case "478":
                case "678":
                case "706":
                case "762":
                case "770":
                case "912":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "GA", 7);

                case "808":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "HI", 7);

                case "208":
                case "986":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "ID", 7);

                case "217":
                case "224":
                case "309":
                case "312":
                case "331":
                case "447":
                case "464":
                case "618":
                case "630":
                case "708":
                case "730":
                case "773":
                case "779":
                case "815":
                case "847":
                case "872":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "IL", 7);

                case "219":
                case "260":
                case "317":
                case "463":
                case "574":
                case "765":
                case "812":
                case "930":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "IN", 7);

                case "319":
                case "515":
                case "563":
                case "641":
                case "712":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "IA", 7);

                case "316":
                case "620":
                case "785":
                case "913":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "KS", 7);

                case "270":
                case "364":
                case "502":
                case "606":
                case "859":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "KY", 7);

                case "225":
                case "318":
                case "337":
                case "504":
                case "985":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "LA", 7);

                case "207":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "ME", 7);


                case "227":
                case "240":
                case "301":
                case "410":
                case "443":
                case "667":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "MD", 7);

                case "339":
                case "351":
                case "413":
                case "508":
                case "617":
                case "774":
                case "781":
                case "857":
                case "978":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "MA", 7);

                case "231":
                case "248":
                case "269":
                case "313":
                case "517":
                case "586":
                case "616":
                case "734":
                case "810":
                case "906":
                case "947":
                case "989":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "MI", 7);

                case "218":
                case "320":
                case "507":
                case "612":
                case "651":
                case "763":
                case "952":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "MN", 7);

                case "228":
                case "601":
                case "662":
                case "769":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "MS", 7);

                case "314":
                case "417":
                case "573":
                case "636":
                case "660":
                case "816":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "MO", 7);

                case "406":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "MT", 7);

                case "308":
                case "402":
                case "531":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "NE", 7);

                case "702":
                case "725":
                case "775":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "NV", 7);

                case "603":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "NH", 7);

                case "201":
                case "551":
                case "609":
                case "640":
                case "732":
                case "848":
                case "856":
                case "862":
                case "908":
                case "973":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "NJ", 7);

                case "505":
                case "575":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "NM", 7);

                case "212":
                case "315":
                case "332":
                case "347":
                case "516":
                case "518":
                case "585":
                case "607":
                case "631":
                case "646":
                case "680":
                case "716":
                case "718":
                case "838":
                case "845":
                case "914":
                case "917":
                case "929":
                case "934":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "NY", 7);

                case "252":
                case "336":
                case "704":
                case "743":
                case "828":
                case "910":
                case "919":
                case "980":
                case "984":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "NC", 7);

                case "701":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "ND", 7);

                case "216":
                case "220":
                case "234":
                case "330":
                case "380":
                case "419":
                case "440":
                case "513":
                case "567":
                case "614":
                case "740":
                case "937":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "OH", 7);

                case "405":
                case "539":
                case "580":
                case "918":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "OK", 7);

                case "458":
                case "503":
                case "541":
                case "971":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "CA", "OR", 7);

                case "215":
                case "223":
                case "267":
                case "272":
                case "412":
                case "445":
                case "484":
                case "570":
                case "610":
                case "717":
                case "724":
                case "814":
                case "878":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "PA", 7);

                case "401":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "RI", 7);

                case "803":
                case "843":
                case "854":
                case "864":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "SC", 7);

                case "605":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "SD", 7);

                case "423":
                case "615":
                case "629":
                case "731":
                case "865":
                case "901":
                case "931":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "TN", 7);

                case "210":
                case "214":
                case "254":
                case "281":
                case "325":
                case "346":
                case "361":
                case "409":
                case "430":
                case "432":
                case "469":
                case "512":
                case "682":
                case "713":
                case "726":
                case "737":
                case "806":
                case "817":
                case "830":
                case "832":
                case "903":
                case "915":
                case "936":
                case "940":
                case "956":
                case "972":
                case "979":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "TX", 7);

                case "385":
                case "435":
                case "801":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "UT", 7);

                case "802":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "VT", 7);

                case "276":
                case "434":
                case "540":
                case "571":
                case "703":
                case "757":
                case "804":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "VA", 7);

                case "206":
                case "253":
                case "360":
                case "425":
                case "509":
                case "564":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "WA", 7);

                case "304":
                case "681":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "WV", 7);

                case "262":
                case "274":
                case "414":
                case "534":
                case "608":
                case "715":
                case "920":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "WI", 7);

                case "307":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "US", "WY", 7);


                // ca
                case "368":
                case "403":
                case "587":
                case "780":
                case "825":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "CA", "AB", 7);

                case "236":
                case "250":
                case "604":
                case "672":
                case "778":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "CA", "BC", 7);

                case "867":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "CA", "?", 7);

                case "204":
                case "431":
                case "584":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "CA", "MB", 7);

                case "506":
                case "428":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "CA", "NB", 7);

                case "709":
                case "879":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "CA", "NL", 7);

                case "782":
                case "902":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "CA", "?", 7);

                case "226":
                case "249":
                case "289":
                case "343":
                case "365":
                case "382":
                case "387":
                case "416":
                case "437":
                case "519":
                case "548":
                case "613":
                case "647":
                case "683":
                case "705":
                case "742":
                case "753":
                case "807":
                case "905":
                case "942":
                   return new CountryCallingCodeResult(1000 + int.Parse(code), "CA", "ON", 7);

                case "263":
                case "354":
                case "367":
                case "418":
                case "438":
                case "450":
                case "468":
                case "514":
                case "579":
                case "581":
                case "819":
                case "873":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "CA", "QC", 7);

                case "306":
                case "474":
                case "639":
                    return new CountryCallingCodeResult(1000 + int.Parse(code), "CA", "SK", 7);

            }

            return new CountryCallingCodeResult();
        }
    }
}
