using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Data;

public partial class Language

{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;
}
