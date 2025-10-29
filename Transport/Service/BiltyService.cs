using DateConverterNepali;
using Microsoft.EntityFrameworkCore;
using Transport.Data;
using Transport.Data.Repositories.IRepositories;
using Transport.Dto;
using Transport.Models;
using Transport.Service.IService;
namespace Transport.Service
{
    public class BiltyService : IBiltyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BiltyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> CreateBiltyAsync(CreateBiltyDto dto)
        {
            var nepaliDate = DateConverter.GetDateInBS(
        dto.BookingDate,
        DateFormats.yMd,    // you can choose other formats like dMy, Myd, etc.
        "/"                 // separator
    );
            var bilty = new Bilty
            {
                SeriesId = dto.SeriesId,
                BiltyNo = dto.BiltyNo,
                BookingDate = dto.BookingDate,
                BookingMiti = nepaliDate.formattedDate,   // e.g. "2081/04/15"
                FromBranchId = dto.FromBranchId,
                ToBranchId = dto.ToBranchId,
                SenderId = dto.SenderId,
                ReceiverId = dto.ReceiverId,
                TruckId = dto.TruckId,
                PaymentMode = dto.PaymentMode,
                TotalAmount = dto.TotalAmount,
                BiltyItems = dto.BiltyItems.Select(i => new BiltyItem
                {
                    PackageTypeId = i.PackageTypeId,
                    GoodsDescription = i.GoodsDescription,
                    Quantity = i.Quantity,
                    Weight = (decimal)i.Weight,
                    Rate = (decimal)i.Rate,
                    Amount = (decimal)(i.Quantity * i.Rate)

                }).ToList()
            };

            _unitOfWork.Bilties.AddAsync(bilty);
            await _unitOfWork.CompleteAsync();
            return bilty.BiltyId;
        }

        public async Task<Bilty> GetBiltyAsync(int id)
        {
            return await _unitOfWork.Bilties.GetBiltyWithItemsAsync(id);
               
        }
    }


}
