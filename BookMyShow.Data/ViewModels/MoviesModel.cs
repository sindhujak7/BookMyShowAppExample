using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Data.ViewModels
{
    public class MoviesModel
    {
        public int? Id { get; set; }

        public string MovieName { get; set; } = null!;

        public DateTime? ReleaseDate { get; set; }

        public bool? AvailabilityStatus { get; set; }

        public double? ContentHours { get; set; }

        public double? Rating { get; set; }

        public int? Votes { get; set; }

        public int? CertificateTypeId { get; set; }

        public  string CertificateTypeName { get; set; }

        public int LanguageId { get; set; }

        public string LanguageName { get; set; }

        public string CityName { get; set; }

        public int? CityId { get;set; }

        


    }
}
