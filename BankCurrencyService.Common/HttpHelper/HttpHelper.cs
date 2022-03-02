namespace BankCurrencyService.Common.HttpHelper
{
    public static class HttpHelper
    {
        public static async Task<HttpResponseMessage> Get(string uri, CancellationToken cancellationToken)
        {
            using var client = new HttpClient();
            try
            {
                using var responseMessage = await client.GetAsync(uri, cancellationToken);

                return responseMessage;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
