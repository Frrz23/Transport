namespace Transport.Models
{
    public class PackageType
    {
        public int PackageTypeId { get; set; }
        public string Name { get; set; }   // e.g. "Box", "Bag", "Drum"
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;

        // Navigation property (optional)
        public List<BiltyItem> BiltyItems { get; set; } = new();
    }
}
