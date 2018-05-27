namespace Tech.NumberValidator
{
    public class TelephoneNumber
    {
        public TelephoneNumber(TelephoneNumber number)
        {
            OriginalNumber = number.OriginalNumber;
            CleanedNumber = number.CleanedNumber;
            InternationalDialingPrefix = number.InternationalDialingPrefix;
            CountryCallingCode = number.CountryCallingCode;
            NationalAccessCode = number.NationalAccessCode;
            SubscribersTrunkDialingCode = number.SubscribersTrunkDialingCode;
            SubscribersNumber = number.SubscribersNumber;
            CountryCallingCodePresent = number.CountryCallingCodePresent;
            ValidNumber = number.ValidNumber;
            Confident = number.Confident;
        }

        public TelephoneNumber(string number)
        {
            OriginalNumber = number;
            CleanedNumber = number;
        }

        public string OriginalNumber { get; set; }
        public string CleanedNumber { get; set; }

        public int InternationalDialingPrefix { get; set; }
        public int CountryCallingCode { get; set; }
        public int NationalAccessCode { get; set; }
        public int SubscribersTrunkDialingCode { get; set; }
        public long SubscribersNumber { get; set; }

        public bool CountryCallingCodePresent { get; set; }
        public bool ValidNumber { get; set; }
        public bool Confident { get; set; }
    }
}
