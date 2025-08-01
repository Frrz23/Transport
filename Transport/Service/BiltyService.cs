using DateConverterNepali;
using Microsoft.EntityFrameworkCore;
using Transport.Data;
using Transport.Dto;
using Transport.Models;
using Transport.Service.IService;
namespace Transport.Service
{
    public class BiltyService : IBiltyService
    {
        private readonly TransportDbContext _context;
        public BiltyService(TransportDbContext context)
        {
            _context = context;
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
                    PackageType = i.PackageType,
                    GoodsDescription = i.GoodsDescription,
                    Quantity = i.Quantity,
                    Weight = (decimal)i.Weight,
                    Rate = (decimal)i.Rate,
                    Amount = (decimal)(i.Quantity * i.Rate)

                }).ToList()
            };

            _context.Bilties.Add(bilty);
            await _context.SaveChangesAsync();
            return bilty.BiltyId;
        }

        public async Task<Bilty> GetBiltyAsync(int id)
        {
            return await _context.Bilties
                .Include(b => b.BiltyItems)
                .FirstOrDefaultAsync(b => b.BiltyId == id);
        }
    }


}
