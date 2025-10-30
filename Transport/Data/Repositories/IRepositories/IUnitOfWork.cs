namespace Transport.Data.Repositories.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        IBiltyRepository Bilties { get; }
        IManifestRepository Manifests { get; }
        IBranchRepository Branches { get; }
        ITruckRepository Trucks { get; }
        IPartyRepository Parties { get; }
        IProductRepository Products { get; }
        ISeriesRepository Series { get; }
        IPakageTypeRepository PakageTypes { get; }
        Task<int> CompleteAsync();
    }
}