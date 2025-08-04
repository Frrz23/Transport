namespace Transport.Models
{
    public class Manifest
    {
        public int Id { get; set; }
        public int SeriesId { get; set; }
        public string ManifestNo { get; set; }
        public DateTime Date { get; set; }
        public string Miti { get; set; }
        public int FromBranchId { get; set; }
        public int TruckId { get; set; }
        public string DriverName { get; set; }
        public string LicenseNo { get; set; }
        public string OwnerName { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string PAN { get; set; }
        public string? Remarks { get; set; }
        public int CreatedBy { get; set; }

        public List<ManifestItem> ManifestItems { get; set; } = new();
    }
}