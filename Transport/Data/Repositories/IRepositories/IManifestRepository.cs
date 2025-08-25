using Transport.Models;

namespace Transport.Data.Repositories.IRepositories
{
    public interface IManifestRepository : IGenericRepository<Manifest>
    {
        Task<Manifest> GetManifestWithItemsAsync(int id);
        Task<List<Manifest>> GetAllManifestsWithItemsAsync();
    }
}