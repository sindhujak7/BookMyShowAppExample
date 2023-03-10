using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Data.ViewModels
{
    public class CustomerModel
    {
        public int? CustomerId { get; set; }
        public int? BookingId { get; set; }
       

        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }
        public double PaymentAmount { get; set; }

        public DateTime? Date { get; set; }

        public string ShowTime { get; set; }

        public string MovieName { get; set; }

        public string TheatreName { get; set; }

        public string TheatreAddress { get; set; }

        public int? ShowTimeId { get; set; }
        public virtual List<ReservedSeatModel> ReservedSeatsModel { get; set; }
    }

    public class BookingModel
    {
        public int? Id { get; set; }

        public int? CustomerId { get; set; }

        public double PaymentAmount { get; set; }

        public DateTime? Date { get; set; }

        public int ShowTimeId { get; set; }

    }
    public class ReservedSeatModel
    {
        public int? Id { get; set; }

        public int SeatLayOutId { get; set; }

        public int? BookingId { get; set; }

        public int? CustomerId { get; set; }

        public List<string> ReservedSeatName { get; set; }

    }

    public class CustomerViewBookingModel
    {
        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public double PaymentAmount { get; set; }

        public DateTime? Date { get; set; }

        public string ShowTime { get; set; }
    }
}
