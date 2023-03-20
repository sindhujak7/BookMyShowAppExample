using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Data;

public partial class SeatCategories
{
    [Key]
    public int Id { get; set; }

    public string SeatCategory { get; set; } = null!;

    public int TheatreId { get; set; }

   // public virtual Theatre Theatre { get; set; } = null!;

   // public virtual ICollection<TheatreTicketPricing> TheatreTicketPricings { get; } = new List<TheatreTicketPricing>();
}
