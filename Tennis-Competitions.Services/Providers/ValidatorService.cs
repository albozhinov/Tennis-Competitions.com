namespace Tennis_Competitions.Services.Providers
{
    using System.ComponentModel.DataAnnotations;

    public class ValidatorService : IValidatorService
    {
        public void NullOrWhiteSpacesCheck(string parameter)
        {
            if (String.IsNullOrEmpty(parameter) ||
                String.IsNullOrWhiteSpace(parameter))
            {
                throw new ArgumentNullException("Nullable or white spaces values are not supported.");
            }

            return;
        }

        public (bool, Guid) TryParseGuid(string guidId)
        {
            Guid parsedArticleId;
            bool isValidId = Guid.TryParse(guidId, out parsedArticleId);

            if (!isValidId)
                return (false, Guid.Empty);

            return (true, parsedArticleId);
        }
    }
}
