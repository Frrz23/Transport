using Microsoft.EntityFrameworkCore;
using Transport.Data;
using Transport.Data.Repositories.IRepositories;
using Transport.Dto;
using Transport.Models;

namespace Transport.Service
{
    public class ManifestService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ManifestService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ManifestDto> CreateManifestAsync(CreateManifestDto dto)
        {
            // Validate BiltyIds exist - using FindAsync from GenericRepository
            var biltyIds = dto.Items.Select(i => i.BiltyId).Distinct().ToList();
            var existingBilties = new List<int>();

            foreach (var biltyId in biltyIds)
            {
                var bilty = await _unitOfWork.Bilties.GetByIdAsync(biltyId);
                if (bilty != null)
                {
                    existingBilties.Add(biltyId);
                }
            }

            var missing = biltyIds.Except(existingBilties).ToList();
            if (missing.Any())
            {
                throw new InvalidOperationException($"Bilty(s) not found: {string.Join(',', missing)}");
            }

            var manifest = new Manifest
            {
                SeriesId = dto.SeriesId,
                ManifestNo = dto.ManifestNo,
                Date = dto.Date,
                Miti = dto.Miti,
                FromBranchId = dto.FromBranchId,
                TruckId = dto.TruckId,
                DriverName = dto.DriverName,
                LicenseNo = dto.LicenseNo,
                OwnerName = dto.OwnerName,
                Phone = dto.Phone,
                Mobile = dto.Mobile,
                PAN = dto.PAN,
                Remarks = dto.Remarks,
                CreatedBy = dto.CreatedBy,
                ManifestItems = new List<ManifestItem>() // Initialize the collection
            };

            foreach (var it in dto.Items)
            {
                var mi = new ManifestItem
                {
                    BiltyId = it.BiltyId,
                    Quantity = it.Quantity,
                    Weight = it.Weight,
                    Destination = it.Destination ?? string.Empty,
                    Consignee = it.Consignee ?? string.Empty,
                    Amount = it.Amount,
                    PaymentMode = it.PaymentMode ?? string.Empty,
                };
                manifest.ManifestItems.Add(mi);
            }

            await _unitOfWork.Manifests.AddAsync(manifest);
            await _unitOfWork.CompleteAsync();

            // Map to ManifestDto to return
            var result = new ManifestDto
            {
                Id = manifest.Id,
                ManifestNo = manifest.ManifestNo,
                Date = manifest.Date,
                Miti = manifest.Miti,
                FromBranchId = manifest.FromBranchId,
                TruckId = manifest.TruckId,
                DriverName = manifest.DriverName,
                Remarks = manifest.Remarks,
                Items = manifest.ManifestItems.Select(i => new ManifestItemDto
                {
                    Id = i.Id,
                    BiltyId = i.BiltyId,
                    Quantity = i.Quantity,
                    Weight = i.Weight,
                    Destination = i.Destination,
                    Consignee = i.Consignee,
                    Amount = i.Amount,
                    PaymentMode = i.PaymentMode
                }).ToList()
            };

            return result;
        }

        public async Task<Manifest?> GetManifestByIdAsync(int id)
        {
            return await _unitOfWork.Manifests.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Manifest>> GetAllManifestsAsync()
        {
            return await _unitOfWork.Manifests.GetAllAsync();
        }

        public async Task<List<ManifestDto>> GetAllAsync()
        {
            // Use the specific method from ManifestRepository
            var manifests = await _unitOfWork.Manifests.GetAllManifestsWithItemsAsync();

            return manifests.Select(m => new ManifestDto
            {
                Id = m.Id,
                ManifestNo = m.ManifestNo,
                Date = m.Date,
                Miti = m.Miti,
                FromBranchId = m.FromBranchId,
                TruckId = m.TruckId,
                DriverName = m.DriverName,
                Remarks = m.Remarks,
                Items = m.ManifestItems.Select(i => new ManifestItemDto
                {
                    Id = i.Id,
                    BiltyId = i.BiltyId,
                    Quantity = i.Quantity,
                    Weight = i.Weight,
                    Destination = i.Destination,
                    Consignee = i.Consignee,
                    Amount = i.Amount,
                    PaymentMode = i.PaymentMode
                }).ToList()
            }).ToList();
        }

        public async Task<bool> DeleteManifestAsync(int id)
        {
            var manifest = await _unitOfWork.Manifests.GetByIdAsync(id);
            if (manifest == null) return false;

            _unitOfWork.Manifests.Delete(manifest);
            await _unitOfWork.CompleteAsync();
            return true;
        }
    }
}