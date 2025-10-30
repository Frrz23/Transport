using Transport.Data.Repositories.IRepositories;
using Transport.Models;

namespace Transport.Data.Repositories
{
    public class PakageTypeRepository : GenericRepository<PackageType>, IPakageTypeRepository
    {
        public PakageTypeRepository(TransportDbContext context) : base(context)
        {
        }
    }
}
