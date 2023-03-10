using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Data;

public partial class ReservedSeat
{
    [Key]
    public int Id { get; set; }

    public int SeatLayOutId { get; set; }

    public int BookingId { get; set; }

    public int CustomerId { get; set; }

   // public virtual BookingDetail Booking { get; set; } = null!;

  //  public virtual Customer Customer { get; set; } = null!;

   // public virtual TheatreSeatLayOut SeatLayOut { get; set; } = null!;
}
