namespace Transport.Models
{
    public class Bilty
    {
        public int BiltyId { get; set; }
        public int SeriesId { get; set; }
        public string BiltyNo { get; set; }
        public DateTime BookingDate { get; set; }
        public string BookingMiti { get; set; }
        public int FromBranchId { get; set; }
        public int ToBranchId { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public int TruckId { get; set; }
        public string PaymentMode { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalWeight { get; set; }
        public decimal Freight { get; set; }
        public decimal STCharge { get; set; }
        public decimal LabourCharge { get; set; }
        public decimal OtherCharge { get; set; }
        public decimal VATAmount { get; set; }
        public int CreatedBy { get; set; }
    }
}
