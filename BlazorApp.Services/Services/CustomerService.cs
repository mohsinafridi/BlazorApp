using BlazorApp.Data.Entities;
using BlazorApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Services.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly BlazorAppDbContext _context;
        public CustomerService(BlazorAppDbContext context)
        {
            _context = context;
        }
        public void DeleteCustomer(int id)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.Id == id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        public Customer GetCustomerById(int id)
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Id == id);
            return customer;
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        public void SaveCustomer(Customer customer)
        {
            if (customer.Id == 0) _context.Customers.Add(customer);
            else _context.Customers.Update(customer);
            _context.SaveChanges();
        }
    }
}
