using Microsoft.EntityFrameworkCore;
using Transport.Data.Repositories.IRepositories;
using Transport.Models;

namespace Transport.Data.Repositories
{
    public class ManifestRepository : GenericRepository<Manifest>, IManifestRepository
    {
        public ManifestRepository(TransportDbContext context) : base(context) { }

        public async Task<Manifest> GetManifestWithItemsAsync(int id)
        {
            return await _context.Manifests
                .Include(m => m.ManifestItems)
                .ThenInclude(i => i.Bilty)
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task<List<Manifest>> GetAllManifestsWithItemsAsync()
        {
            return await _context.Manifests
                .Include(m => m.ManifestItems)
                .ToListAsync();
        }
    }
}