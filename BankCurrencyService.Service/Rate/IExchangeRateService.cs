using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCurrencyService.Service.Rate
{
    public interface IExchangeRateService
    {
        Task GetOnlineExchangeRateECB(CancellationToken cancellationToken);
    }
}
