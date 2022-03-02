using BankCurrencyService.Service.Rate;

namespace BankCurrencyService.Infrastructure.BackgroundProcess
{
    public class DelayedExchaneFetchWorkers : BackgroundService
    {
        public IServiceProvider Services { get; }
        public IConfiguration _configuration { get; }

        public DelayedExchaneFetchWorkers(IServiceProvider services,
            IConfiguration configuration)
        {
            Services = services;
            _configuration = configuration;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var time = _configuration["RefreshExchangeRateTimeByMinute"];
            //TODO: it should be done by TryParse
            var delayTimeByMinute = string.IsNullOrEmpty(time) ? 360 : Convert.ToInt32(time);

            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = Services.CreateScope())
                {
                    var _service =
                        scope.ServiceProvider
                            .GetRequiredService<IExchangeRateService>();

                    await _service.GetOnlineExchangeRateECB(stoppingToken);
                }

                await Task.Delay(TimeSpan.FromMinutes(delayTimeByMinute), stoppingToken);
            }
        }
    }
}
