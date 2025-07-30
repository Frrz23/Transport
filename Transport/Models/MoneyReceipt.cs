namespace Transport.Models
{
    public class MoneyReceipt
    {
        public int MoneyReceiptId { get; set; }
        public string ReceiptNo { get; set; }
        public DateTime Date { get; set; }
        public int PartyId { get; set; }
        public decimal Amount { get; set; }
        public string Mode { get; set; }
        public string Remarks { get; set; }
        public int ReceivedBy { get; set; }
        public Party Party { get; set; }
    }
}