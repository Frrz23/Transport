namespace Transport.Models
{
    public class BiltyItem
    {
        public int BiltyItemId { get; set; }
        public int BiltyId { get; set; }
        public Bilty Bilty { get; set; }

        public int? ProductId { get; set; }
        public Product? Product { get; set; }

        public int? PackageTypeId { get; set; }
        public PackageType? PackageType { get; set; }

        public string GoodsDescription { get; set; }
        public int Quantity { get; set; }
        public decimal Weight { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public string? Remarks { get; set; }
    }

}