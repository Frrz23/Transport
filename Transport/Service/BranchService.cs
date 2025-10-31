using Transport.Data.Repositories.IRepositories;
using Transport.Models;
using Transport.Service.IService;

namespace Transport.Service
{
    public class BranchService : IBranchService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BranchService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Branch>> GetAllAsync() =>
            await _unitOfWork.Branches.GetAllAsync();

        public async Task<Branch> GetByIdAsync(int id) =>
            await _unitOfWork.Branches.GetByIdAsync(id);

        public async Task<Branch> CreateAsync(Branch branch)
        {
            await _unitOfWork.Branches.AddAsync(branch);
            await _unitOfWork.CompleteAsync();
            return branch;
        }

        public async Task<Branch> UpdateAsync(Branch branch)
        {
            _unitOfWork.Branches.Update(branch);
            await _unitOfWork.CompleteAsync();
            return branch;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var branch = await _unitOfWork.Branches.GetByIdAsync(id);
            if (branch == null) return false;

            _unitOfWork.Branches.Delete(branch);
            await _unitOfWork.CompleteAsync();
            return true;
        }
    }
}
