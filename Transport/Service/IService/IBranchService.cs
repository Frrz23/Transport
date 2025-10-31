using Transport.Models;

namespace Transport.Service.IService
{
    public interface IBranchService
    {
        Task<IEnumerable<Branch>> GetAllAsync();
        Task<Branch> GetByIdAsync(int id);
        Task<Branch> CreateAsync(Branch branch);
        Task<Branch> UpdateAsync(Branch branch);
        Task<bool> DeleteAsync(int id);
    }
}
