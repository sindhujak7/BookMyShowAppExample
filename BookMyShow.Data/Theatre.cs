using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Data;

public partial class Theatre
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int CityId { get; set; }

    //public virtual City City { get; set; } = null!;
    //public virtual TheatreShow TheatreShows { get; set; } = null!;

    //public virtual SeatCategories SeatCategories { get; set; } = null!;

    //public virtual TheatreSeatLayOut TheatreSeatLayOut { get; set; } = null!;
    //public virtual TheatreTicketPricing TheatreTicketPricing { get; set; } = null!;

   
}
