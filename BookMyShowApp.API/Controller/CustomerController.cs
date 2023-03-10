using BookMyShow.Data;
using BookMyShow.Data.ViewModels;
using BookMyShowApp.API.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BookMyShowApp.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomer customer;

        private IBookingDetails _bookingDetails;

        public CustomerController(ICustomer customer, IBookingDetails bookingDetails)
        {
            this.customer = customer;
            _bookingDetails = bookingDetails;
        }



        [HttpPost]
        public async Task<ActionResult> Create(CustomerModel customer)
        {
            await this.customer.SaveCustomerDetails(customer);

            if(customer.PaymentAmount != 0.00)
            {
                await _bookingDetails.SaveBookingDetails(customer ,customer.ReservedSeatsModel);
            }

            return Ok(customer);


        }
    }
}
