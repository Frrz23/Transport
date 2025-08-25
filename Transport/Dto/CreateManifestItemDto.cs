namespace Transport.Dto
{
    public class CreateManifestItemDto
    {
        public int BiltyId { get; set; }
        public int Quantity { get; set; }
        public decimal Weight { get; set; }
        public string? Destination { get; set; }
        public string? Consignee { get; set; }
        public decimal Amount { get; set; }
        public string? PaymentMode { get; set; }
    }

}
