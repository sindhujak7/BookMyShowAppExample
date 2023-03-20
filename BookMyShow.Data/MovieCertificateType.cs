using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Data;

public partial class MovieCertificateType
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

   // public virtual ICollection<Movie> Movies { get; } = new List<Movie>();
}
