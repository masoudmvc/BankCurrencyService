using AutoMapper;
using BankCurrencyService.Domain.Entities.Currency;
using BankCurrencyService.Domain.Entities.Rate;
using BankCurrencyService.DTO.Currency;
using BankCurrencyService.DTO.Rate;

namespace BankCurrencyService.Service
{
    public class AutomapperInitializer : Profile
    {
        public AutomapperInitializer()
        {
            CreateMap<CountryCurrency, CountryCurrencyDto>();
            
            CreateMap<ExchangeRateDetail, ExchangeRateDetailDto>();
            
            CreateMap<ExchangeRate, ExchangeRateDto>()
                .ForMember(dest => dest.ExchangeRateResourceName, 
                    source => source.MapFrom(x => x.ExchangeRateResource.ResourceName));
        }
    }
}
