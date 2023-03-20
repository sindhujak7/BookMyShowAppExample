using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Data.ViewModels
{
    public class SeatCategoryWithPriceDetails
    {
        public int Id { get; set; }
        public string SeatCategory  { get; set; }
        public int  TheatreId { get; set; }
        public double Price { get; set; }

    }
}
