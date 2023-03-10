using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Data;

public partial class TheatreSeatLayOut
{
    [Key]
    public int Id { get; set; }

    public string Row { get; set; } = null!;

    public string Number { get; set; } = null!;

    public string Section { get; set; } = null!;

    public int TheatreId { get; set; }

   
}
