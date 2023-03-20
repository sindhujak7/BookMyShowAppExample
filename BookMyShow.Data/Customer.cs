using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookMyShow.Data;

public partial class Customer
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    
    public virtual BookingDetail BookingDetails { get; set; }
    public virtual ICollection<ReservedSeat> ReservedSeats { get; set; }
}
