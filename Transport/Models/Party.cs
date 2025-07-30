namespace Transport.Models
{
    public class Party
    {
        public int PartyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PAN { get; set; }
        public string VATType { get; set; } // General, Retail, None
    }
}