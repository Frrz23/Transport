namespace Transport.Models
{
    public class ManifestItem
    {
        public int ManifestItemId { get; set; }
        public int ManifestId { get; set; }
        public int BiltyId { get; set; }
        public decimal Weight { get; set; }
        public decimal Amount { get; set; }

        public Manifest Manifest { get; set; }
        public Bilty Bilty { get; set; }
    }
}