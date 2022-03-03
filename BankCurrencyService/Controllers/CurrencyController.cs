using BankCurrencyService.DTO.Currency;
using BankCurrencyService.DTO.Rate;
using BankCurrencyService.DTO.ServiceOutputBase;
using BankCurrencyService.Service.Currency;
using BankCurrencyService.Service.Rate;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BankCurrencyService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly IExchangeRateService _exchangeRateService;
        private readonly ICurrencyService _currencyService;
        public CurrencyController(IExchangeRateService exchangeRateService,
            ICurrencyService currencyService)
        {
            _exchangeRateService = exchangeRateService;
            _currencyService = currencyService;
        }

        /// <summary>
        /// Request to get all currencies.
        /// </summary>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<ListQueryResult<CountryCurrencyDto>>> GetAllCurrencies(CancellationToken cancellationToken)
        {
            var result = await _currencyService.GetAllCurrencies(cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Request to get available currencies.
        /// </summary>
        [HttpGet("available")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<SingleQueryResult<ExchangeRateDto>>> GetAvailableCurrencies(CancellationToken cancellationToken)
        {
            var result = await _exchangeRateService.GetAvailableCurrencies(cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Request to fetch available exchange rates' currencies from Europesn Central Bank
        /// </summary>
        [HttpPost("fetch-online-available-rate")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<DTO.ServiceOutputBase.EmptyResult>> CreateDialysisSession(CancellationToken cancellationToken)
        {
            await _exchangeRateService.FetchOnlineExchangeRateECB(cancellationToken);
            return Created("", new DTO.ServiceOutputBase.EmptyResult());
        }

    }
}
