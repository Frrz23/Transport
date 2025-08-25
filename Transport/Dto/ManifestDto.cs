namespace Transport.Dto
{
    public class ManifestDto
    {
        public int Id { get; set; }
        public string ManifestNo { get; set; } = null!;
        public DateTime Date { get; set; }
        public string? Miti { get; set; }
        public int FromBranchId { get; set; }
        public int TruckId { get; set; }
        public string? DriverName { get; set; }
        public string? Remarks { get; set; }
        public List<ManifestItemDto> Items { get; set; } = new();
    }


}
