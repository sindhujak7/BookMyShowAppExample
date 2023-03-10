using BookMyShow.Data;

namespace BookMyShowApp.API.Interface
{
    public interface ILanguages
    {
        Task<IEnumerable<Language>> GetLanguages();
    }
}
