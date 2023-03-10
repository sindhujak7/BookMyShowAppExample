using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Data;

public partial class Movie
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? ReleaseDate { get; set; }

    public bool? AvailabilityStatus { get; set; }

    public double? ContentHours { get; set; }

    public double? Rating { get; set; }

    public int? Votes { get; set; }

    public int? CertificateTypeId { get; set; }

    public virtual MovieCertificateType? CertificateType { get; set; }
}
