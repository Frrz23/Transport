namespace Transport.Dto
{
    public class CreateBiltyItemDto
    {
        public string PackageType { get; set; }
        // In your BiltyItemDto
        public int PackageTypeId { get; set; }

        public string GoodsDescription { get; set; }
        public int Quantity { get; set; }
        public double Weight { get; set; }
        public double Rate { get; set; }
    }
}