using Transport.Data.Repositories.IRepositories;

namespace Transport.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TransportDbContext _context;

        public IBiltyRepository Bilties { get; private set; }
        public IManifestRepository Manifests { get; private set; }
        public IBranchRepository Branches { get; private set; }
        public ITruckRepository Trucks { get; private set; }
        public IPartyRepository Parties { get; private set; }
        public IProductRepository Products { get; private set; }
        public ISeriesRepository Series { get; private set; }
        public IPakageTypeRepository PakageTypes { get; private set; }



        public UnitOfWork(TransportDbContext context)
        {
            _context = context;
            Bilties = new BiltyRepository(_context);
            Manifests = new ManifestRepository(_context);
            Branches = new BranchRepository(_context);
            Trucks = new TruckRepository(_context);
            Parties = new PartyRepository(_context);
            Products = new ProductRepository(_context);
            Series = new SeriesRepository(_context);
            PakageTypes = new PakageTypeRepository(_context);

        }

        public async Task<int> CompleteAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}    