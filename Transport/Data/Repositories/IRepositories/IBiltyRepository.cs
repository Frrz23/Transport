using Transport.Models;

namespace Transport.Data.Repositories.IRepositories
{
    public interface IBiltyRepository : IGenericRepository<Bilty>
    {
        Task<Bilty> GetBiltyWithItemsAsync(int id);
        Task<IEnumerable<Bilty>> GetAllBiltiesWithItemsAsync();

    }
}
