
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;

using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Domain.Interfaces;
using MIcroRabbit.Banking.Data.Context;
using MIcroRabbit.Banking.Data.Repository;


namespace MicroRabbit.Infra.IoC
{
    public class DependcyContainer
    {
        public static void RegisterServices(IServiceCollection services) {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            //Application Services
            services.AddTransient<IAccountService, AccountService>();

            //Data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
        }
    }
}
