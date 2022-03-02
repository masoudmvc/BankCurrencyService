﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCurrencyService.Common.Contracts
{
    public interface IConfig
    {
        void Configure(IServiceCollection services, IConfiguration configuration);
    }
}
