using Transport.Data.Repositories.IRepositories;

namespace Transport.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TransportDbContext _context;

        public IBiltyRepository Bilties { get; private set; }
        public IManifestRepository Manifests { get; private set; }

        public UnitOfWork(TransportDbContext context)
        {
            _context = context;
            Bilties = new BiltyRepository(_context);
            Manifests = new ManifestRepository(_context);
        }

        public async Task<int> CompleteAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}    