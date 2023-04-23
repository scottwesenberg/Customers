using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers
{
    public class ViewModel
    {
        private List<Customer> customers;
        private int currentCustomer;
        public ViewModel() 
        {
            this.currentCustomer = 0;
            this.customers = new List<Customer>()
            {
                new Customer
                {
                    CustomerID = 1,
                    Title = "Mr",
                    FirstName = "John",
                    LastName = "Sharp",
                    Email = "john@contoso.com",
                    Phone = "111-1111"
                },
                new Customer
                {
                    CustomerID = 2,
                    Title = "Mrs",
                    FirstName = "Diana",
                    LastName = "Sharp",
                    Email = "diana@contoso.com",
                    Phone = "222-2222"
                },
                new Customer
                {
                    CustomerID = 3,
                    Title = "Ms",
                    FirstName = "Francesca",
                    LastName = "Sharp",
                    Email = "fran@contoso.com",
                    Phone = "333-3333"
                }
            };

        }
        public Customer Current
        {
            get => this.customers.Count > 0 ? this.customers[currentCustomer] : null;
        }
    }
}
