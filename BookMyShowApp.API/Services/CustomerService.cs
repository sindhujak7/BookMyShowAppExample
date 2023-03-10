using BookMyShow.Data;
using BookMyShow.Data.ViewModels;
using BookMyShowApp.API.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookMyShowApp.API.Services
{
    public class CustomerService : ICustomer
    {
        private readonly BookMyShowContext _context;
        public CustomerService(BookMyShowContext context) {
        
        this._context = context;
        }

        public async Task<IEnumerable<Customer>> GetCustomerDetails()
        {
            var data=await _context.Customers.ToListAsync();
            return data;
        }

        public  async Task<IEnumerable<Customer>> GetCustomerDetailsById(int id)
        {
            var data = await _context.Customers.Where(x=>x.Id==id).ToListAsync();
            return data;
        }

        public async Task<IEnumerable<Customer>> SaveCustomerDetails(CustomerModel data)
        {

            var cst = new Customer()
            {
                Name = data.Name,
                Address=data.Address,
                City=data.City,
                PhoneNumber=data.PhoneNumber,
                Email=data.Email,
                
            };
          
            await _context.Customers.AddAsync(cst);
            await  _context.SaveChangesAsync();
            data.CustomerId=cst.Id;
            var result = await GetCustomerDetailsById((int)data.CustomerId);
            return result;
        }
    }
}
