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
    public class RateController : ControllerBase
    {
        private readonly IExchangeRateService _exchangeRateService;
        public RateController(IExchangeRateService exchangeRateService)
        {
            _exchangeRateService = exchangeRateService;
        }


        /// <summary>
        /// Request to get a currency rate by acronym Abb.
        /// </summary>
        [HttpGet("available/acronym-abb/{acronym-abb}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<SingleQueryResult<ExchangeRateDetailDto>>> GetCurrencyRate(
            [FromRoute(Name = "acronym-abb")] string acronymAbb,
            CancellationToken cancellationToken)
        {
            var result = await _exchangeRateService.GetCurrencyRate(acronymAbb, cancellationToken);
            return Ok(result);
        }

        /// <summary>
        /// Request to convert amount of money from a currency to another 
        /// </summary>
        [HttpPost("convert")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<ConvertDto>> ConvertFromBaseRate(
            [FromBody] ConvertCommand command, CancellationToken cancellationToken)
        {
            var result = await _exchangeRateService.ConvertFromBaseRate(command, cancellationToken);
            return Created("", result);
        }

        /// <summary>
        /// Request to withdraw amount of money based on Currency of the country 
        /// </summary>
        [HttpPost("withdraw-money")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<WithdrawDTO>> WithdrawMoney(
            [FromBody] WithdrawCommand command, CancellationToken cancellationToken)
        {
            var result = await _exchangeRateService.WithdrawMoney(command, cancellationToken);
            return Created("", result);
        }
    }
}
