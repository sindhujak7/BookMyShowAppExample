using BookMyShow.Data;
using BookMyShow.Data.ViewModels;
using BookMyShowApp.API.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace BookMyShowApp.API.Services
{
    public class TheatreService : ITheatres
    {
        private readonly BookMyShowContext _context;
        public TheatreService(BookMyShowContext context)
        {
            _context = context;
        }

       

        public async Task<IEnumerable<Theatre>> GetTheatres(int CityId)
        {
            var theatre = await _context.Theatres.Where(x=>x.CityId==CityId).ToListAsync();
            //var theatre = (from ct in _context.Cities  
            //              join th in _context.Theatres  on ct.Id equals th.CityId 
            //             group ct by ct.Id into data  

            //              select new CitiesModel
            //              {
            //                 CityName=,
            //                  CityId=ct.Id,
            //                  theatresModels=(List<TheatresModel>)data


            //              }).Where(th=>th.CityId==CityId).ToList();

            //return theatre;

            //var results = from th in _context.Theatres
            //              join ct in _context.Cities on th.CityId equals ct.Id
            //              group ct.Id by  into g
            //              select new { PersonId = g.Key, Cars = g.ToList() };

            //var data = await _context.Cities.GroupJoin(_context.Theatres, ct => ct.Id, th => th.CityId, (ct, th) => new { ct, th }).ToListAsync();

            //var data = await _context.Cities.GroupJoin(_context.Theatres, ct => ct.Id, th => th.CityId, (ct, th) => new  CitiesModel{ 

            //    CityId= ct.Id,
            //    CityName= ct.Name,
            //    theatresModels=  th.ToList()

            //}).ToListAsync();


            //return (List<CitiesModel>)data;

            return theatre;
        }


       


       
        public async Task<IEnumerable<SeatCategoryWithPriceDetails>> GetSeatCategoryWithPriceDetails(int TheatreId)
        {
            //var theatre = await _context.Theatres.Where(x=>x.CityId==CityId).ToListAsync();
                var priceDetails =  (from sc in _context.SeatCategories
                               join th in _context.Theatres on sc.TheatreId equals th.Id
                               join pr in _context.TheatreTicketPricing on sc.Id equals pr.CategoryId
                               where sc.TheatreId == TheatreId
                               select new BookMyShow.Data.ViewModels.SeatCategoryWithPriceDetails
                               {
                                   Id = sc.Id,
                                   SeatCategory = sc.SeatCategory,
                                   TheatreId =sc.TheatreId,
                                   Price=pr.Price
                                  


                               });
                return priceDetails;
           
        }

        public async Task<IEnumerable<TheatreShow>> GetSeatShows(int TheatreId)
        {
            var shows= await _context.TheatreShows.Where(x => x.TheatreId == TheatreId).ToListAsync();

            return shows;
        }

        public async Task<IEnumerable<TheatreOnShowTypes>> GetTheatresOnShowTypes(int ShowTypeId ,int CityId)
        {
            var shows  =  (from sc in _context.ShowTypes
                                join th in _context.TheatreShows on sc.Id equals th.ShowTypeId
                                join pr in _context.Theatres on th.TheatreId equals pr.Id
                                where sc.Id == ShowTypeId
                                select new BookMyShow.Data.ViewModels.TheatreOnShowTypes
                                {
                                   
                                    TheatreId=th.TheatreId,
                                    CityId=CityId ,
                                    Name=pr.Name,
                                    ShowTypeId=ShowTypeId ,
                                    ShowTypeName=sc.ShowType1



                                });

            return shows;


        }


        public async Task<IEnumerable<TheatreSeatLayOut>> GetTheatreSeatLayOuts(int TheatreId)
        {

            var data = _context.TheatreSeatLayOut.Where(a => !_context.ReservedSeats.Select(b => b.SeatLayOutId).Contains(a.Id));
            return data;

        }

    }
}
