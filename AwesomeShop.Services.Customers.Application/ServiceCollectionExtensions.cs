using AwesomeShop.Services.Customers.Application.Commands;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AwesomeShop.Services.Customers.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            services.AddMediatR(typeof(AddCustomer));

            return services;
        }
    }
}
