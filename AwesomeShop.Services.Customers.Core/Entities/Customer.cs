using System;
using AwesomeShop.Services.Customers.Core.ValueObjects;

namespace AwesomeShop.Services.Customers.Core.Entities
{
    public class Customer 
    {
        public Customer(Guid id, string fullName, DateTime birthDate, string email)
        {
            Id = id;
            FullName = fullName;
            BirthDate = birthDate;
            Email = email;
        }

        public Guid Id { get; set; }
        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string PhoneNumber { get; private set; }
        public Address Address { get; private set; }
        public string Email { get; private set; }

    }
}