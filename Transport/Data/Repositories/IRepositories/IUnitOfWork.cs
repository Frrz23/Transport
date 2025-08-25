namespace Transport.Data.Repositories.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        IBiltyRepository Bilties { get; }
        IManifestRepository Manifests { get; }
        Task<int> CompleteAsync();
    }
}