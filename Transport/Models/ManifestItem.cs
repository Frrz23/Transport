namespace Transport.Models
{
    public class ManifestItem
    {
        public int Id { get; set; }
        public int ManifestId { get; set; }
        public int BiltyId { get; set; }
        public int Quantity { get; set; }
        public decimal Weight { get; set; }
        public string Destination { get; set; }
        public string Consignee { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMode { get; set; }

        public Manifest Manifest { get; set; }
        public Bilty Bilty { get; set; }
    }

}