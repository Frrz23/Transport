using Transport.Dto;
using Transport.Models;

namespace Transport.Service.IService
{
    public interface IBiltyService
    {
        Task<int> CreateBiltyAsync(CreateBiltyDto dto);
        Task<Bilty> GetBiltyAsync(int id);
    }

}
