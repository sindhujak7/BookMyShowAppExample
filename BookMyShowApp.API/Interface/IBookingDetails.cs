using BookMyShow.Data;
using BookMyShow.Data.ViewModels;

namespace BookMyShowApp.API.Interface
{
    public interface IBookingDetails
    {

        Task<IEnumerable<CustomerModel>> SaveBookingDetails(CustomerModel detail ,List<ReservedSeatModel> model);

        Task<IEnumerable<CustomerModel>> GetBookingDetailsById(int id);

    }
}
