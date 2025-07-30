namespace Transport.Models
{
    public class Manifest
    {
        public int ManifestId { get; set; }
        public int SeriesId { get; set; }
        public string ManifestNo { get; set; }
        public DateTime Date { get; set; }
        public string Miti { get; set; }
        public int FromBranchId { get; set; }
        public int TruckId { get; set; }
        public int DriverId { get; set; }
        public string Remarks { get; set; }
        public int CreatedBy { get; set; }
    }
}