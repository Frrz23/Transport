using Transport.Data.Repositories.IRepositories;
using Transport.Models;

namespace Transport.Data.Repositories
{
    public class PartyRepository : GenericRepository<Party>, IPartyRepository
    {
        public PartyRepository(TransportDbContext context) : base(context)
        {
        }
    }
}
