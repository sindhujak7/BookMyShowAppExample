using BookMyShow.Data;
using BookMyShowApp.API.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BookMyShowApp.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingDetailsController : ControllerBase
    {
        private ITheatres _theatres;
        private ICustomer _customer;
        private IBookingDetails _bookingDetails;
        public BookingDetailsController(ITheatres theatres , ICustomer customer ,IBookingDetails  bookingDetails) {
        
            this._theatres = theatres;
            this._customer = customer;
            this._bookingDetails = bookingDetails;
        }

        [HttpGet("customerid")]
        public  async Task<ActionResult> Get(int customerid)
        {
            var data= await _bookingDetails.GetBookingDetailsById(customerid);
            return Ok(data);

        }

        //[HttpPost]
        //public async Task<ActionResult> Create(Customer details)
        //{
        //    var data = await _customer.SaveCustomerDetails(details);           

        //    await  _bookingDetails.SaveBookingDetails(details);

        //    return Ok(details);
        //}
    }
}
