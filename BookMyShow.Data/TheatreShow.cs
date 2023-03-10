using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Data;

public partial class TheatreShow
{
    [Key]
    public int Id { get; set; }

    public int TheatreId { get; set; }

    public int MovieId { get; set; }

    public int ShowTypeId { get; set; }

    public string StartEndTime { get; set; } = null!;
}
