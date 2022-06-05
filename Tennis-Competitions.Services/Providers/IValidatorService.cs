namespace Tennis_Competitions.Services.Providers
{
    public interface IValidatorService
    {
        public void NullOrWhiteSpacesCheck(string parameter);

        public (bool, Guid) TryParseGuid(string guidId);
    }
}
