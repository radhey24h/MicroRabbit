﻿using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void ResisterServices(IServiceCollection services)
        {

            // domain bus
           // services.AddTransient<IEventBus, RabbitMQBus>();

            //application service
           // services.AddTransient<IAccountService, AccountService>();

            //Data
            services.AddTransient<AccountRepository, AccountRepository>();
            services.AddTransient<BankingDBContext>();
        }
    }
}
