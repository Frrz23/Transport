using Transport.Models;

namespace Transport.Service.IService
{
    public interface IManifestService
    {
        Task<Manifest> CreateManifestAsync(Manifest manifest);
        Task<Manifest?> GetManifestByIdAsync(int id);
        Task<IEnumerable<Manifest>> GetAllManifestsAsync();
        Task<bool> DeleteManifestAsync(int id);
    }
}
