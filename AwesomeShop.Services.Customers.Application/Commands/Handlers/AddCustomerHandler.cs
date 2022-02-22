using System;
using System.Threading;
using System.Threading.Tasks;
using AwesomeShop.Services.Customers.Core.Entities;
using AwesomeShop.Services.Customers.Core.Repositories;
using MediatR;

namespace AwesomeShop.Services.Customers.Application.Commands.Handlers
{
    public class AddCustomerHandler : IRequestHandler<AddCustomer, Guid>
    {
        private readonly ICustomerRepository _repository;
        public AddCustomerHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(AddCustomer request, CancellationToken cancellationToken)
        {
            var customer = Customer.Create(request.FullName, request.BirthDate, request.Email);

            await _repository.AddAsync(customer);

            return customer.Id;
        }
    }
}