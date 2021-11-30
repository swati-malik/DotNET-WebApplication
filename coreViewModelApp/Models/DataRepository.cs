using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreViewModelApp.Models
{
    public class DataRepository
    {
        public CustomerAddressModel DataSource()
        {
            Customer customer = new Customer()
            {
                CustomerId = 1001,
                Name = "King Kochar",
                Gender = "Male",
                Amount = 12000
            };
            Address address = new Address()
            {
                StreetName = "32",
                City = "Ghaziabad",
                PinCode = "201009",
                Country = "India"

            };
            CustomerAddressModel customerAddressModel = new CustomerAddressModel()
            {
                Customer = customer,
                Address = address,
                Title = "Customer Address Information"
            };
            return customerAddressModel;

        }
    }
}
