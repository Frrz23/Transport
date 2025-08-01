namespace Transport.Dto
{
    public class CreateBiltyDto
    {
        public int SeriesId { get; set; }
        public string BiltyNo { get; set; }
        public DateTime BookingDate { get; set; }
        public int FromBranchId { get; set; }
        public int ToBranchId { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public int TruckId { get; set; }
        public string PaymentMode { get; set; }
        public decimal TotalAmount { get; set; }
        public List<CreateBiltyItemDto> BiltyItems { get; set; }
    }
}
