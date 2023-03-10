using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Data.ViewModels
{
    public class TheatreOnShowTypes
    {
        public int TheatreId { get; set; }

        public string Name { get;set; }

        public int CityId { get; set; }

        public int ShowTypeId { get; set; }

        public string ShowTypeName { get; set; }
        

    }
}
