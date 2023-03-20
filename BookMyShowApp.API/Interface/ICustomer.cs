using BookMyShow.Data;
using BookMyShow.Data.ViewModels;

namespace BookMyShowApp.API.Interface
{
    public interface ICustomer
    {
        Task<IEnumerable<Customer>> SaveCustomerDetails(CustomerModel c);

        Task<IEnumerable<Customer>> GetCustomerDetails();
        Task<IEnumerable<Customer>> GetCustomerDetailsById(int id);
    }
}
