using Bogus;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.FakeData
{
    public class Fakers
    {
        Faker<Customer>? _customerFaker = null;
        Faker<Address>? _addressFaker = null;

        public Faker<Customer> CustomerGenerator(bool includeAddress)
        {
            if (_customerFaker == null)
            {
                int id = 1;
                _addressFaker = AddressGenerator();

                _customerFaker = new Faker<Customer>()
                    .UseSeed(1) //Will always generate same collection
                    .RuleFor(x => x.Id, f => id++)
                    .RuleFor(x => x.CompanyName, f => f.Company.CompanyName())
                    .RuleFor(x => x.Name, f => f.Name.FirstName())
                    .RuleFor(x => x.Surname, f => f.Name.LastName())
                    .RuleFor(x => x.PhoneNumber, f => f.Phone.PhoneNumber());

                if (includeAddress)
                {
                    _customerFaker = _customerFaker
                        .RuleFor(x => x.Address, f => _addressFaker.Generate(1).First());
                }
            }

            return _customerFaker;
        }

        public Faker<Address> AddressGenerator()
        {
            if (_addressFaker == null)
            {
                int id = 1;

                _addressFaker = new Faker<Address>()
                    .UseSeed(1) //Will always generate same collection
                    .RuleFor(x => x.Id, f => id++)
                    .RuleFor(x => x.FirstLine, f => f.Address.StreetName())
                    .RuleFor(x => x.SecondLine, f => f.Address.BuildingNumber())
                    .RuleFor(x => x.City, f => f.Address.City())
                    .RuleFor(x => x.State, f => f.Address.State())
                    .RuleFor(x => x.ZipCode, f => f.Address.ZipCode())
                    .RuleFor(x => x.Country, f => "United States");
            }

            return _addressFaker;
        }
    }
}
