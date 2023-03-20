using BookMyShow.Data;
using BookMyShowApp.API.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookMyShowApp.API.Services
{
    public class LanguageService : ILanguages
    {
        private readonly BookMyShowContext _context;
        public LanguageService(BookMyShowContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Language>> GetLanguages()
        {
            var languages = from ln in _context.Languages
                            select ln;
            return languages;
        }
    }
}
