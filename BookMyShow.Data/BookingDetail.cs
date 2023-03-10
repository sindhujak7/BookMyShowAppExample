using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Data;

public partial class BookingDetail
{
    [Key]
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public double PaymentAmount { get; set; }

    public DateTime? Date { get; set; }

    public int ShowTimeId { get; set; }

  
}
