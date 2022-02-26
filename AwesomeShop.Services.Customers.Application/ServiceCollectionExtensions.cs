using AwesomeShop.Services.Customers.Application.Commands;
using AwesomeShop.Services.Customers.Application.Subscribers;
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
        public static IServiceCollection AddSubscribers(this IServiceCollection services)
        {
            services.AddHostedService<CustomerCreatedSubscriber>();

            return services;
        }
    }
}
