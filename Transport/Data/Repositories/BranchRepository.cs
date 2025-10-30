using Microsoft.EntityFrameworkCore;
using Transport.Data.Repositories.IRepositories;
using Transport.Models;

namespace Transport.Data.Repositories
{
    public class BranchRepository : GenericRepository<Branch>, IBranchRepository
    {
        public BranchRepository(TransportDbContext context) : base(context)
        {
        }
    }
}