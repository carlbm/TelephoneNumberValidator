namespace Tech.NumberValidator.NumberCleaners
{
    interface INumberCleaner
    {
        TelephoneNumber TestAndClean(TelephoneNumber number);
    }
}
