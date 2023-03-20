using BookMyShow.Data;
using BookMyShow.Data.ViewModels;
using BookMyShowApp.API.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookMyShowApp.API.Services
{
    public class BookingService :IBookingDetails
    {
        private readonly BookMyShowContext _context;
        public BookingService(BookMyShowContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<BookMyShow.Data.ViewModels.CustomerModel>> GetBookingDetailsById(int id)
        {



            var data = (from cm in _context.Customers
                        join bd in _context.BookingDetails on cm.Id equals bd.CustomerId                        
                        join st in _context.TheatreShows on bd.ShowTimeId equals st.Id
                        join  mv in _context.Movies on  st.MovieId equals mv.Id
                        join th in _context.Theatres on st.TheatreId equals th.Id

                        where cm.Id == id
                        select new BookMyShow.Data.ViewModels.CustomerModel
                        {
                            CustomerId = cm.Id,
                            Name = cm.Name,
                            Address = cm.Address,
                            
                            PhoneNumber=cm.PhoneNumber,
                            Email=cm.Email,
                            City=cm.City,
                            PaymentAmount= bd.PaymentAmount,                            
                            MovieName=mv.Name,
                            TheatreName=th.Name,
                            TheatreAddress =th.Address,
                            Date = bd.Date,
                            ShowTime = st.StartEndTime



                        });



            return data;
        }
        public async Task<IEnumerable<CustomerModel>> SaveBookingDetails(CustomerModel data ,List<ReservedSeatModel> model)
        {

            var cst = new BookingDetail()
            {
                CustomerId =Convert.ToInt32(data.CustomerId),
                PaymentAmount = data.PaymentAmount,
                Date = data.Date,
                ShowTimeId = Convert.ToInt32(data.CustomerId)

            };
           
            await _context.BookingDetails.AddAsync(cst);
            await _context.SaveChangesAsync();

                    data.BookingId = cst.Id;
                    foreach (var item in model)
                    {
                        var dt = new ReservedSeat()
                        {
                            CustomerId = Convert.ToInt32(data.CustomerId),
                            BookingId = (int)data.BookingId,
                            SeatLayOutId = item.SeatLayOutId
                        };
                        await _context.ReservedSeats.AddAsync(dt);
                        await _context.SaveChangesAsync();

                    }


            var details = await GetBookingDetailsById(cst.Id);

                            return details;


        }

        

    }
}
