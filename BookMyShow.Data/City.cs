using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Data;

public partial class City
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    //public virtual ICollection<Theatre> Theatres { get; } = new List<Theatre>();
}
