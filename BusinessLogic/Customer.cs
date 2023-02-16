using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Customer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? CompanyName { get; set; }
        public string? PhoneNumber { get; set; }
        public Address? Address { get; set; }
        public int AddressId { get; set; }
    }
}
