using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookMyShow.Data;

public partial class TheatreTicketPricing
{
    [Key]
    public int Id { get; set; }

    
    public int TheatreId { get; set; }

   
    public int CategoryId { get; set; }

    public double Price { get; set; }

    [ForeignKey("CategoryId")]
    public virtual SeatCategories SeatCategory { get; set; } = null!;


    [ForeignKey("TheatreId")]
    public virtual Theatre Theatre { get; set; } = null!;
}
