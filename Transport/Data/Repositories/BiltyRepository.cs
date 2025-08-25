using Microsoft.EntityFrameworkCore;
using Transport.Data.Repositories.IRepositories;
using Transport.Models;

namespace Transport.Data.Repositories
{
    public class BiltyRepository : GenericRepository<Bilty>, IBiltyRepository
    {
        public BiltyRepository(TransportDbContext context) : base(context) { }

        public async Task<Bilty> GetBiltyWithItemsAsync(int id)
        {
            return await _context.Bilties
                .Include(b => b.BiltyItems)
                .FirstOrDefaultAsync(b => b.BiltyId == id);
        }
        public async Task<IEnumerable<Bilty>> GetAllBiltiesWithItemsAsync()
        {
            return await _context.Bilties
                .Include(b => b.BiltyItems)
                .ToListAsync();
        }
    }
}