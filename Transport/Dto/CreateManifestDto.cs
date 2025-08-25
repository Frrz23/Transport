namespace Transport.Dto
{
    public class CreateManifestDto
    {
        public int SeriesId { get; set; }
        public string ManifestNo { get; set; } = null!;
        public DateTime Date { get; set; }
        public string? Miti { get; set; }                 // optional BS date
        public int FromBranchId { get; set; }
        public int TruckId { get; set; }
        public string? DriverName { get; set; }
        public string? LicenseNo { get; set; }
        public string? OwnerName { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public string? PAN { get; set; }
        public string? Remarks { get; set; }
        public int CreatedBy { get; set; }
        public List<CreateManifestItemDto> Items { get; set; } = new();
    }

}
