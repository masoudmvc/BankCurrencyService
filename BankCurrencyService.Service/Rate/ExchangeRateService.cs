using BankCurrencyService.Common.Constants;
using BankCurrencyService.Common.XmlHelper;
using BankCurrencyService.Service.Base;
using System.Net;

namespace BankCurrencyService.Service.Rate
{
    public class ExchangeRateService : ServiceBase, IExchangeRateService
    {
        public ExchangeRateService(IServiceEssentials<ExchangeRateService> _serviceEssentials) : base(_serviceEssentials)
        {

        }

        public async Task GetOnlineExchangeRateECB(CancellationToken cancellationToken)
        {
            try
            {
                using var client = new HttpClient();
                using var responseMessage = await client
                    .GetAsync(ValidationConstants.EcbUri, cancellationToken);

                if (responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    var responseString = await responseMessage.Content.ReadAsStringAsync();

                    if (!string.IsNullOrWhiteSpace(responseString))
                    {
                        var response = XmlHelper.FromXml<Envelope>(responseString);

                        if (response.Success)
                        {
                            var time = response.Entity?.Cube.Cube1.time;
                            var list = response.Entity?.Cube.Cube1.Cube;
                        }
                    }
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
