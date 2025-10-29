namespace Transport.Models
{
    public class Truck
    {
        public int TruckId { get; set; }
        public string PlateNumber { get; set; }
        public string OwnerName { get; set; }
        public string PAN { get; set; }
        public string License { get; set; }
        public string Mobile { get; set; }
        public bool IsActive { get; set; } = true;

    }
}
