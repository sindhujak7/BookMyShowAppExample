using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookMyShow.Data;

public partial class MovieLanguageDetail
{
    
    public int MovieId { get; set; }

    public int LanguageId { get; set; }

    public int TheatreId { get; set; }

    public virtual Language Language { get; set; } = null!;

    public virtual Movie Movie { get; set; } = null!;

    public virtual Theatre Theatre { get; set; } = null!;
}
