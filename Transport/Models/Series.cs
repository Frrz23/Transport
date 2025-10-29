namespace Transport.Models
{
    public class Series
    {
        public int SeriesId { get; set; }
        public string Name { get; set; }
        public string Prefix { get; set; }
        public int NextNumber { get; set; }
        public string UsedFor { get; set; } // Bilty, Manifest, Receipt
        public int BranchId { get; set; }

        public Branch Branch { get; set; }
        public bool IsActive { get; set; } = true;

    }
}