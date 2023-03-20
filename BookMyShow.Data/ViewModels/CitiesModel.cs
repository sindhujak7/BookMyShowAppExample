using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Data.ViewModels
{
    public class CitiesModel
    {
        public int? CityId { get; set; }
        public string CityName { get; set; }

     // public virtual  List<TheatresModel> theatresModels { get; set; }=new List<TheatresModel>();
    }

    public class TheatresModel
    {
        //public int? TheatreId { get; set; }
        //public string TheatreName { get; set; }
        //public string TheatreAddress { get; set; }
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Address { get; set; } = null!;

        public int CityId { get; set; }
    }

}
