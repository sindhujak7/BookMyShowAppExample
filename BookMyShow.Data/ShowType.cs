using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Data;

public partial class ShowType
{
    [Key]
    public int Id { get; set; }

    public string ShowType1 { get; set; } = null!;

    public string Description { get; set; } = null!;

   // public virtual ICollection<TheatreShow> TheatreShows { get; } = new List<TheatreShow>();
}
