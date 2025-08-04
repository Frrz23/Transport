namespace Transport.Dto
{
    public class ManifestDto
    {
        public int Id { get; set; }
        public string MfNo { get; set; }
        public string? NepaliDate { get; set; }
        public DateTime Date { get; set; }

        public string TruckNo { get; set; }
        public string DriverName { get; set; }
        public string FromBranchName { get; set; }

        public List<ManifestItemDto> Items { get; set; }
    }



}
